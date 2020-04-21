using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    Vector2 currentP;
    Vector2 incomingP;
    float disp;
    float accumDisp;
    int maxCoinSize = 2;

    public GameObject coinPrefab;
    public GameObject force;
    //public int coinCounter = 0;

    GameObject coin;
    //public UnityEngine.UI.Text counterText;
    //string prefix = "Coin: ";

    // public accelReader accelerationReader;
    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = new Vector3(0.01f, 0.01f, 0);
        currentP.x = transform.position.x;
        currentP.y = transform.position.y;

        disp = 0;
        accumDisp = 0;
        coin = null;
        //counterText.text = prefix + coinCounter;
    }

    // Update is called once per frame
    void Update()
    {
        disp = Mathf.Abs(transform.position.sqrMagnitude - currentP.sqrMagnitude);
        accumDisp += disp;

        


        if (disp > 0)
        {
            if (coin == null)
            {
                coin = Instantiate(coinPrefab);
                Vector3 tempPos = coin.transform.localPosition;
                coin.GetComponent<HingeJoint2D>().connectedBody = gameObject.transform.GetComponent<Rigidbody2D>();
                coin.transform.parent = gameObject.transform;
                coin.transform.localPosition = tempPos;
                coin.transform.localScale = new Vector3(0, 0, 0);
            }
            else
            {
                if (coin.transform.localScale.x < maxCoinSize)
                {
                    coin.transform.localScale += 0.01f * new Vector3(1, 1, 1);
                    //Debug.Log("inside if" + coin.transform.localScale);
                }
                else
                {
                    coin.transform.localScale = maxCoinSize * new Vector3(1, 1, 0);
                    coin.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
                    accumDisp = 0;
                    coin.transform.parent = null;
                    Destroy(coin.GetComponent<HingeJoint2D>());
                    coin.AddComponent<SelfDestroy>();
                    coin = null;
                    //IncrementCoinCounter();
                    //Debug.Log("inside else" + coin.transform.localScale);
                }
                
            }
        }

        //Debug.Log("accumDisp is " + accumDisp);



        //clear up data
        disp = 0;
        currentP = transform.position;
    }

    

    //void IncrementCoinCounter()
    //{
    //    coinCounter++;
    //    counterText.text = prefix + coinCounter;
    //}
}
