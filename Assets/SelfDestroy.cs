using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyMyself", 5);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void DestroyMyself()
    {
        Destroy(gameObject);
    }
}
