using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class random_move : MonoBehaviour
{

 
    // Start is called before the first frame update
    Vector2 startingPos;
    Vector2 endingPos;

    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //mobile accelerometer
        if ( (accelReader.main.accelChange > 0.1f) || Input.GetKeyDown(KeyCode.Space))
        {
            MoveAss();
        }



    }

    void MoveAss()
    {
        Vector2 tempDisp = (Vector2)Random.insideUnitCircle;
        endingPos = startingPos + tempDisp;
        transform.position = endingPos;
    }
}
