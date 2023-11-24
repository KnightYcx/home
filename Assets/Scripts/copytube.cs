using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copytube : MonoBehaviour
{
    [SerializeField] private Tube tubeperfab;
    [SerializeField] private float maxY;
    [SerializeField] private float minY;
    [SerializeField] private float Stime;
    [SerializeField] private GameManager gamemanager;
    float timer = 0f;
    
    public void Update()
    {
        if (gamemanager.isgameover) return;
        timer += Time.deltaTime;
        if (timer >= Stime)
        {
            spawntube();
            timer = 0f;
        }
        
    }
    public void spawntube() 
    {
        Vector3 spawnpo = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);
        Instantiate(tubeperfab, spawnpo,Quaternion.identity);
    }

}
