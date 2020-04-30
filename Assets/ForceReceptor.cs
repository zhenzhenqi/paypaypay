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

        rb.drag = 5;
        rb.angularDrag = 5;
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (accelReader.main.accelChange.magnitude > 0.3f)
        {
            targetForce = Random.insideUnitCircle * accelReader.main.accelChange.magnitude / 3;
            //rb.AddForce(targetForce);
            rb.MovePosition(transform.position + targetForce);
        }
    }


}
