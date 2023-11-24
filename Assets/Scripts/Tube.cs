using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float temp;
    [SerializeField] private GameManager gamemanager;
    [SerializeField] private float myspeed;
    private void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
         if (gamemanager.isgameover) return;

        transform.Translate (Vector3.forward*-1 * myspeed * Time.deltaTime);
        if (transform.position.z < temp)
        {
            Destroy(gameObject);
        }
    }
}
