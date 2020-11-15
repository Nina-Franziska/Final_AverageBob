using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructCollide : MonoBehaviour
{

    public GameObject destroyedVersion;



    private void OnCollisionEnter(Collision collision)
    {

        if (collision.relativeVelocity.magnitude > 2)
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);

        }



    }

}
