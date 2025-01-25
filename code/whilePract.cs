using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whilePract : MonoBehaviour
{
    public int time;
    public int maxTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        time = maxTime;
        startTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startTimer(){
        StartCoroutine(timer());
        Debug.Log("the tymar hes stertid");
    }

    public IEnumerator timer(){
        while(time > 0){
            yield return new WaitForSeconds(1.0f);
            time = time - 1;  /*no me gusta usar e "time--''*/
        }
        Debug.Log("timer dune");
    }
}