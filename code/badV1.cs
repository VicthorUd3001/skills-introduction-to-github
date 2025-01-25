using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badV1 : MonoBehaviour
{
    public int badHealth = 10;
    public GameObject me;
    public GameObject it;
    
    // Start is called before the first frame update
    void Start()
    {
        it.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(badHealth <= 0)
        {
            me.SetActive(false);
            it.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pickup"))
        {
            badHealth += -1;
        }
    }
}
