using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botHealth : MonoBehaviour
{
    public int health;
    public int botBase = 5;
    // Start is called before the first frame update
    void Start()
    {
        setCheck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setCheck(){
        if (health == 5)
        {
            botBase =+ health;
        }
        else if (health == 10)
        {
            botBase =+ health;
        }
        else if (health == 15)
        {
            botBase =+ health;
        }
        else if (health == 20)
        {
            botBase =+ health;
        }
    }
}
