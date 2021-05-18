using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    public float speed = 35.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//еда лети по направлению 
    {
      transform.Translate (Vector3.forward * Time.deltaTime * speed );    
    }
}
