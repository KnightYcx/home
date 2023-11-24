using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    [SerializeField] private float myspeed;
    [SerializeField] private float moveZ;
    [SerializeField] private float Zoffset;
    [SerializeField] private GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gamemanager.isgameover) return;
        transform.Translate(Vector3.forward*-1*myspeed*Time.deltaTime );
        if (transform .position .z<=moveZ) 
        {
            transform.position = new Vector3(transform .position .x, transform.position .y, Zoffset);
        }
    }
}
