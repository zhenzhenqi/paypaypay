using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceReceptorSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //add force receptor to all children nodes
        var allchildren = gameObject.GetComponentsInChildren<Rigidbody2D>();

        foreach (var node in allchildren)
        {
            //Debug.Log("adding forceReceptor to " + node.gameObject.name);
            if (node.gameObject.name == "tail") continue;
            var transfo = node.gameObject.AddComponent<ForceReceptor>();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
