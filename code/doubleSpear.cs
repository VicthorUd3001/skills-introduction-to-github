using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleSpear : MonoBehaviour
{
    public int it1;
    public GameObject it3;
    // Start is called before the first frame update
    void Start()
    {
        it1 = 0;
        it3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (it1 > 2)
         {
             it3.SetActive(true);
         }
    }
}
