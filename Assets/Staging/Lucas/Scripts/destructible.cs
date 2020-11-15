using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class destructible : MonoBehaviour
{
    public GameObject destroyedVersion;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.relativeVelocity.magnitude > 2)
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);

        }
          
    

    }



}
