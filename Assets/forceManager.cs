﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceManager : MonoBehaviour
{
    public bool isColliding;
    public GameObject accelReader;
    [Range(1, 1000)] public int thrust;
    private Vector3 accelVal;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        isColliding = false;
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        accelVal = accelReader.GetComponent<accelReader>().accelChange;
        Debug.Log("accelVal "+accelVal);
        //transform.position = transform.position + accelVal*thrust;
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector3.Scale(new Vector3(-1,-1,1), accelVal) * thrust);
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

