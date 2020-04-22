using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceManager : MonoBehaviour
{
    public bool isColliding;
    public GameObject accelReader;
    private Vector3 accelVal;

    // Start is called before the first frame update
    void Start()
    {
        isColliding = false;
        accelVal = accelReader.GetComponent<accelReader>().accelChange;
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + accelVal;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isColliding = true;
            //Debug.Log("isCollding: " + isColliding);
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isColliding = false;
            //Debug.Log("isCollding: " + isColliding);
        }

    }
}

