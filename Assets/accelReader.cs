using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelReader : MonoBehaviour
{

    public static accelReader main;
    // Start is called before the first frame update

    Vector3 currentA;
    Vector3 incomingA;
    public Vector3 accelChange;


    private void Awake()
    {
        main = this;
    }

    void Start()
    {
        //accelChange = 0;
        currentA = Vector3.zero;
        incomingA = Vector3.zero;
        accelChange = Vector3.zero;

        currentA.x = Input.acceleration.x;
        currentA.y = Input.acceleration.y;
        currentA.z = Input.acceleration.z;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Input.acceleration: " + Input.acceleration);
        incomingA.x = Input.acceleration.x;
        incomingA.y = Input.acceleration.y;
        incomingA.z = Input.acceleration.z;
        //Debug.Log("incomingA: " + incomingA);

        //accelChange = Mathf.Abs(incomingA.sqrMagnitude - currentA.sqrMagnitude);
        accelChange = incomingA - currentA;
        Debug.Log("accelChange from accel reader: "+accelChange);

        currentA.x = Input.acceleration.x;
        currentA.y = Input.acceleration.y;
        currentA.z = Input.acceleration.z;
        
    }
}
