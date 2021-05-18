using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] animalsPrefab;
    private float SpawnPosX = 20;
    private float SpawnPosZ = 30;
    private float startDelay =  2;
    private float spawnInterval  = 1.5f ;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
       

    }

    // Update is called once per frame
    void Update()//при нажатие проиходит спавн 
    {
     if (Input.GetKeyDown(KeyCode.S))
       {
         SpawnRandomAnimal();
       }  
    }
    
    void SpawnRandomAnimal()//рандомный спавн объектов 
    {
             int animalsIndex = Random.Range(0, animalsPrefab.Length);

         Vector3 spawnPos = new Vector3 (Random.Range(-SpawnPosX,SpawnPosX), 0, SpawnPosZ);

         Instantiate(animalsPrefab[animalsIndex] ,  spawnPos, animalsPrefab[animalsIndex].transform.rotation);
    }
}
