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
        //if (Input.GetKeyDown("space")){
        if (accelerationReader.accelChange>0.1f){
            Vector2 tempDisp = (Vector2)Random.insideUnitCircle;
//			Debug.Log(tempDisp);
			endingPos = startingPos + tempDisp;
			transform.position = endingPos;
		}
    }
}
