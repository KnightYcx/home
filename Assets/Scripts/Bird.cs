using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody RigidbodybBird;
    [SerializeField] private float jump;
    [SerializeField] private Animator bridAnimator;
    [SerializeField] private GameManager gamemanager;
    [SerializeField] private GameObject crashsomke;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip addSound;
    [SerializeField] private AudioClip crashSound;
    void Update()
    {
        if (gamemanager.isgameover) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //up 是上下是指y轴 forward 是前后是z轴 right 是左右是x轴
            RigidbodybBird.velocity = Vector3.up * jump;
        }
        if (RigidbodybBird.velocity.y > 0)
        {
            bridAnimator.SetBool("fly",true);
        }
        else
        {
            bridAnimator.SetBool("fly", false);
        }
    

}
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Tube"))
        {
            gamemanager.Addscore();
            audioSource.PlayOneShot(addSound);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(crashSound);
        gamemanager.setGameover();
        Instantiate(crashsomke,transform .position , Quaternion.identity);
        bridAnimator.SetBool("fly", false);
    }
}
