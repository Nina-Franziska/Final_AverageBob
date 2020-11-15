using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteTask : MonoBehaviour
{

    [SerializeField]
    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Grab"))
        {
            other.enabled = false;
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.transform.position = transform.position;


            sound.Play();

        }


    }
}
