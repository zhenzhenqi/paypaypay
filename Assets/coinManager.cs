using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    Vector2 currentP;
    Vector2 incomingP;
    float disp;
    float accumDisp;
    public GameObject coinPrefab;

    public int coinCounter = 0;

    public int maxCoinSize = 100;

    GameObject coin;
    public UnityEngine.UI.Text counterText;
    string prefix = "Coin: ";

    // public accelReader accelerationReader;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.01f, 0.01f, 0);
        currentP.x = transform.position.x;
        currentP.y = transform.position.y;

        disp = 0;
        accumDisp = 0;
        coin = null;
        counterText.text = prefix + coinCounter;
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
                coin = GameObject.Instantiate(coinPrefab, Vector3.zero, Quaternion.identity);

                coin.transform.parent = gameObject.transform;
                coin.transform.localPosition = Vector2.zero;
            }
            else
            {
                if (accumDisp < maxCoinSize)
                {
                    coin.transform.localScale = accumDisp * new Vector3(1, 1, 0);
                }
                else
                {
                    coin.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
                    accumDisp = 0;
                    coin.transform.parent = null;
                    coin.AddComponent<SelfDestroy>();
                    coin = null;
                    IncrementCoinCounter();
                }
            }
        }

        Debug.Log("accumDisp is " + accumDisp);



        //clear up data
        disp = 0;
        currentP = transform.position;
    }

    void IncrementCoinCounter()
    {
        coinCounter++;
        counterText.text = prefix + coinCounter;
    }
}
