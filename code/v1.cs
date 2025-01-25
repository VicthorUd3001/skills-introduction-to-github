using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v1 : MonoBehaviour
{
    public int weath;
    public pickUp weapUno;
    public pickUp weapDos;
    public pickUp weapTres;
    public int healthData;
    public int maxHealth = 12;

    public GameObject cam;

    public int hpItems = 0;

    public GameObject play;

    //If this i will later add a healing item to the game
    public GameObject potionOne;
    public GameObject potionTwo;
    public GameObject potionThree;
    public int t;
    public GameObject weapOne;
    public GameObject weapTwo;
    public GameObject weapThree;
    public int dmg;


    // Start is called before the first frame update
    void Start()
    {
        cam.SetActive(false);
        healthData = maxHealth;
        dmg = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(healthData == 0)
        {
            play.SetActive(false);
            cam.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            healthData += -1;
        }
        if (collision.gameObject.CompareTag("hpPotion"))
        {
            weath = 0;
            upHpCheck();
        }
        if (collision.gameObject.CompareTag("hpPotionTwo"))
        {
            weath = 1;
            upHpCheck();
        }
        if (collision.gameObject.CompareTag("instaKill"))
        {
            healthData = 0;
            play.SetActive(false);
            cam.SetActive(true);
            Debug.Log("You touched the void");
        }
        if (collision.gameObject.CompareTag("Weapon")){
            CheckWeapon();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            healthData = 0;
        }
    }
    void upHpCheck()
    {
        //this will check if you have the item and/or how many of them you have
        Debug.Log("Your He aleng");
        if (healthData == 12)
        {
            if (weath == 0)
            {
            Debug.Log("You are at full hp dummie...  You wasted that potion");
            potionOne.SetActive(false);
            hpItems++;
            }
            else if (weath == 1)
            {
            Debug.Log("You are at full hp dummie...  You wasted that potion");
            potionTwo.SetActive(false);
            hpItems++;
            }
            else if (weath == 2)
            {
            Debug.Log("You are at full hp dummie...  You wasted that potion");
            potionThree.SetActive(false);
            hpItems++;
            }
        }
        else if (healthData >= 1 || healthData <= 11)
        {
            if (weath == 0)
            {
                potionOne.SetActive(false);
                hpItems++;
                healthData++;
            }
            else if (weath == 1)
            {
                potionTwo.SetActive(false);
                hpItems++;
                healthData++;
            }
            else if (weath == 2)
            {
                potionThree.SetActive(false);
                hpItems++;
                healthData++;
            }
                healthData++;
                hpItems++;
                healthData++;
        }
        else if (healthData == 0)
        {
            Debug.Log("You're dead bro, skill issue");
        }
    }
    public void CheckWeapon(){
        if(weapUno == true){
            dmg = dmg + 5;
        }
        else if(weapDos == true){
            dmg = dmg + 5;
        }
        else if(weapTres == true){
            dmg = dmg + 5;
        }
    }
}

