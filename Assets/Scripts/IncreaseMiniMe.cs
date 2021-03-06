﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMiniMe : MonoBehaviour
{

    [SerializeField]
    GameObject hip;

    [SerializeField]
    float intialSpringAmount = 1000f;


    [SerializeField]
    float bendOverAmount = 200f;

    [SerializeField]
    bool taskCompleted = false;


    [SerializeField]
    GameObject miniMe;

    [SerializeField]
    public float scaleAmount;

    float scale = 1.1f;


   //s Vector3 scale;
    ConfigurableJoint joint;
    JointDrive drive;

    float time = 0;



    // Start is called before the first frame update

    void Start()
    {
        //scale = new Vector3(scaleAmount, scaleAmount, scaleAmount);

        drive = new JointDrive();
        joint = hip.GetComponent<ConfigurableJoint>();


        drive.positionSpring = intialSpringAmount;
        drive.positionDamper = 25;
        drive.maximumForce = 3.402823e+38f;
        joint.zDrive = drive;
        joint.xDrive = drive;
        joint.yDrive = drive;



    }

    // Update is called once per frame
    void Update()

    {

        CompletedTasksCounter();
        BurdenOverTime();





    }







    void CompletedTasksCounter()
    {
        if (taskCompleted == true) { 
            if (drive.positionSpring >= 0)
            {

                miniMe.transform.localScale *= scale;
                scaleAmount += 0.1f;
                drive.positionSpring -= bendOverAmount;
                joint.zDrive = drive;
                joint.xDrive = drive;
                joint.yDrive = drive;
             
            

            }

            else
            {
                drive.positionSpring = 0;
           

            }

            taskCompleted = false;




        }


    }


    void BurdenOverTime()
    {

        time += Time.deltaTime;

       

        if (time >= 5)
        {

            taskCompleted = true;
            time = 0;



        }


  

    }



}
