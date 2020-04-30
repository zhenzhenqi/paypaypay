using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceReceptor : MonoBehaviour
{

    Rigidbody2D rb;

    //for testing drawing
    Vector3 targetForce = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (accelReader.main.accelChange.magnitude > 0)
        {
            targetForce = Random.insideUnitCircle * accelReader.main.accelChange * 200;
            rb.AddForce(targetForce);
        }
    }


}
