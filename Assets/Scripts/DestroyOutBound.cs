using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{
    private float topBount = 30 ; 
    private float lowBound = - 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//игрок проигрывает,когда персонажи покидают комнату 
    {
        if (transform.position.z > topBount )
        {
         Destroy(gameObject);
        }else if (transform.position.z < lowBound)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
