using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

[SerializeField]
float speed = 0.5f;


    void FixedUpdate()
    {


        float translationZ = Input.GetAxis("Vertical") * speed;
        float translationX = Input.GetAxis("Horizontal") * speed;

        transform.Translate(translationX, 0, translationZ);
        //transform.Translate(translationX, 0, translation);


       
    }
}

