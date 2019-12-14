using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelReader : MonoBehaviour
{

    public static accelReader main;
    // Start is called before the first frame update
    public float accelChange;
    Vector3 currentA;
    Vector3 incomingA;


    private void Awake()
    {
        main = this;
    }

    void Start()
    {
        accelChange = 0;
        currentA = Vector3.zero;
        incomingA = Vector3.zero;
        currentA.x = Input.acceleration.x;
        currentA.y = Input.acceleration.y;
        currentA.z = Input.acceleration.z;

    }

    // Update is called once per frame
    void Update()
    {
        incomingA.x = Input.acceleration.x;
        incomingA.y = Input.acceleration.y;
        incomingA.z = Input.acceleration.z;

        accelChange = Mathf.Abs(incomingA.sqrMagnitude - currentA.sqrMagnitude);

        currentA.x = Input.acceleration.x;
        currentA.y = Input.acceleration.y;
        currentA.z = Input.acceleration.z;

        //Debug.Log(accelChange);
    }
}
