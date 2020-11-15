using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIckUp : MonoBehaviour
{
    [SerializeField]
    Transform hand;

    bool handFree = true;




    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        IsItGrabbable();

    }





    void IsItGrabbable()
    {


        GameObject[] grabObjArray = GameObject.FindGameObjectsWithTag("Grab");
    
        for(int i = 0; i < grabObjArray.Length; i++) {

        float dist =  Vector3.Distance(transform.position, grabObjArray[i].transform.position);

            if (dist < 1)
            {

                Grab(grabObjArray[i]);

  


            }

        }


    }



    void Grab(GameObject grabObj)
    {

        if (Input.GetKeyDown(KeyCode.Space) && handFree == true)
        {

            handFree = false;
            grabObj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            grabObj.GetComponent<Collider>().enabled = false;
            grabObj.GetComponent<Rigidbody>().isKinematic = true;
            grabObj.GetComponent<Rigidbody>().useGravity = false;
            grabObj.transform.position = hand.position;
            grabObj.transform.parent = hand;



        }

        if (handFree == false)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                print("throw");

                grabObj.GetComponent<Collider>().enabled = true;
                grabObj.GetComponent<Rigidbody>().isKinematic = false;
                grabObj.GetComponent<Rigidbody>().useGravity = true; 
                grabObj.transform.parent = null;
                handFree = true;


            }



        }


    }

}
