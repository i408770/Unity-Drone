using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Collider")
        {
            Destroy(col.gameObject);
        }
    }

}

