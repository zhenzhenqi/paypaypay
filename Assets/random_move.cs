using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class random_move : MonoBehaviour
{

    public accelReader accelerationReader;
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
        //if (accelerationReader.accelChange > 0.1f) {
        //    Vector2 tempDisp = (Vector2)Random.insideUnitCircle;
        //    endingPos = startingPos + tempDisp;
        //    transform.position = endingPos;
        //}

        //desktop debug
        if (Input.GetKeyDown("space")){
            Vector2 tempDisp = (Vector2)Random.insideUnitCircle;
            endingPos = startingPos + tempDisp;
            transform.position = endingPos;
        }
    }
}
