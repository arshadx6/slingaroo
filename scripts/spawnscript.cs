using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{   public Transform[] spawnPoints;
    public GameObject[] balloons;


    void Start()
    {
        
    }

    IEnumerator StartSpawning(){ 
        yield return new WaitForSeconds(4); 
        for(int i=0;i<3;i++){
            Instantiate(balloons[0],spawnPoints[i].position,Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
}
