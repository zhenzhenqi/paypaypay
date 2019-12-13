using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    Vector2 currentP;
    Vector2 incomingP;
    float disp;
    float accumDisp;

    public accelReader accelerationReader;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.01f, 0.01f, 0);
        currentP.x = transform.position.x;
        currentP.y = transform.position.y;

        disp = 0;
        accumDisp = 0;

    }

    // Update is called once per frame
    void Update()
    {
        incomingP.x = transform.position.x;
        incomingP.y = transform.position.y;

        disp = Mathf.Abs(incomingP.sqrMagnitude - currentP.sqrMagnitude);
        accumDisp += disp;
        Debug.Log("accumDisp is "+ accumDisp);

        if (accumDisp<2000){
            transform.localScale = accumDisp*0.0005f * new Vector3(1, 1, 0);
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
        }
    }
}
