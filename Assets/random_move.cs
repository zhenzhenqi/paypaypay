using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class random_move : MonoBehaviour
{
    [SerializeField]
    private float multiplier;

    // Start is called before the first frame update
    Vector2 startingPos;
    Vector2 endingPos;

    void Start()
    {
        startingPos = transform.position;
        multiplier = 2.0f;
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
        Vector2 tempDisp = (Vector2)Random.insideUnitCircle * multiplier;
        endingPos = startingPos + tempDisp;
        transform.position = endingPos;
    }
}
