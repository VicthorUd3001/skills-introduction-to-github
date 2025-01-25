using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyDiff : MonoBehaviour
{
    public GameObject bouty;
    public float turnSpeed = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            bouty.transform.Rotate(0, turnSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            bouty.transform.Rotate(0, -turnSpeed, 0);
        }

    }
}
