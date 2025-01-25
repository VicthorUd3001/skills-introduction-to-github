using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weather : MonoBehaviour
{
    public botHealth lala;
    public enum mood
    {
        happy,
        sad,
        mad,
        idk
    }

    public v1 vScript;
    public GameObject health12;
    public GameObject health11;
    public GameObject health10;
    public GameObject health9;
    public GameObject health8;
    public GameObject health7;
    public GameObject health6;
    public GameObject health5;
    public GameObject health4;
    public GameObject health3;
    public GameObject health2;
    public GameObject health1;


    // Start is called before the first frame update
    void Start()
    {
        moodCheck();
        //diffCheck();
        Debug.Log("Your selected difficulty is " + diffiCurrent);
    }

    // Update is called once per frame
    void Update()
    {
        healthCheck();
    }

    void healthCheck()
    {
        switch(vScript.healthData)
        {
            case 12:
                Debug.Log("12 Health");
                health12.SetActive(true);
                health11.SetActive(true);
                health10.SetActive(true);
                health9.SetActive(true);
                health8.SetActive(true);
                health7.SetActive(true);
                health6.SetActive(true);
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 11:
                Debug.Log("11 Health");
                health12.SetActive(false);
                health11.SetActive(true);
                health10.SetActive(true);
                health9.SetActive(true);
                health8.SetActive(true);
                health7.SetActive(true);
                health6.SetActive(true);
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 10:
                Debug.Log("10 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(true);
                health9.SetActive(true);
                health8.SetActive(true);
                health7.SetActive(true);
                health6.SetActive(true);
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 9:
                Debug.Log("9 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(true);
                health8.SetActive(true);
                health7.SetActive(true);
                health6.SetActive(true);
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 8:
                Debug.Log("8 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(false);
                health8.SetActive(true);
                health7.SetActive(true);
                health6.SetActive(true);
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 7:
                Debug.Log("7 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(false);
                health8.SetActive(false);
                health7.SetActive(true);
                health6.SetActive(true);
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 6:
                Debug.Log("6 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(false);
                health8.SetActive(false);
                health7.SetActive(false);
                health6.SetActive(true);
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 5:
                Debug.Log("5 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(false);
                health8.SetActive(false);
                health7.SetActive(false);
                health6.SetActive(false);
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 4:
                Debug.Log("4 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(false);
                health8.SetActive(false);
                health7.SetActive(false);
                health6.SetActive(false);
                health5.SetActive(false);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 3:
                Debug.Log("3 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(false);
                health8.SetActive(false);
                health7.SetActive(false);
                health6.SetActive(false);
                health5.SetActive(false);
                health4.SetActive(false);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 2:
                Debug.Log("2 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(false);
                health8.SetActive(false);
                health7.SetActive(false);
                health6.SetActive(false);
                health5.SetActive(false);
                health4.SetActive(false);
                health3.SetActive(false);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 1:
                Debug.Log("1 Health");
                health12.SetActive(false);
                health11.SetActive(false);
                health10.SetActive(false);
                health9.SetActive(false);
                health8.SetActive(false);
                health7.SetActive(false);
                health6.SetActive(false);
                health5.SetActive(false);
                health4.SetActive(false);
                health3.SetActive(false);
                health2.SetActive(false);
                health1.SetActive(true);
                break;
            case 0:
                Debug.Log("0 hp");
                break;
        }
    }
    void moodCheck()
    {
        if (curent == mood.happy)
        {
            Debug.Log("be happy, stay happy, define happy");
        }
        if (curent == mood.sad)
        {
            Debug.Log("you gonna cry, no llores bb");
        }
        if (curent == mood.idk)
        {
            Debug.Log("you are a literal bot, no feelings, just wow");
        }
        if (curent == mood.mad)
        {
            Debug.Log("rage quit i don't care");
        }

    }
    public mood curent = mood.idk;

    public string[] difficulty = { "Mondongo", "Frezas", "Cell", "ESCENCIAL" };
    public string diffiCurrent;
    /*
    void diffCheck(){
        if (curent == mood.idk){
            diffiCurrent = difficulty[2];
            lala.health =+ 5;
        }
        if (curent == mood.happy){
            diffiCurrent = difficulty[1];
            lala.health =+ 5;
        }
        if (curent == mood.sad){
            diffiCurrent = difficulty[0];
            lala.health =+ 2;
        }
        if (curent == mood.mad){
            diffiCurrent = difficulty[3];
            lala.health =+ 5;
        }
    }
    */
}