using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("colliding with coin" + other.gameObject.name);
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("colliding with coin"+other.gameObject.name);
        }

    }
}
