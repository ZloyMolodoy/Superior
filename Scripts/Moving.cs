using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{

    public Vector2 vector = new Vector2(50, 50);
    //[Range(1,100)]
    //public float run;
    //public bool inRun;
   

    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
       //if(Input.GetKeyDown("left shift")) { inRun = true; } else { inRun = false; }

        //if (Input.GetKeyDown("left shift") || inRun )
        //{
        //    Vector3 move = new Vector3(vector.x * inputX * run, vector.y * inputY * run, 0);

        //    move *= Time.deltaTime;

        //    transform.Translate(move);
        //}
        //else 
        //{
            Vector3 move = new Vector3(vector.x * inputX, vector.y * inputY, 0);

            move *= Time.deltaTime;

            transform.Translate(move);
        //}


    }
}
