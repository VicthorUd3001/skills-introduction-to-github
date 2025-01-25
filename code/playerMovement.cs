using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 50;
    public float jumpHigh = 10;
    public float turnSpeed = 2;
    public AudioSource audioSource;
    public AudioClip coinCollectSound;
    public string ig;
    
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(speed > 50 || speed < 50)
        {
            speed = 50;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(0, turnSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(0, -turnSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * jumpHigh);
        }
    }
}

