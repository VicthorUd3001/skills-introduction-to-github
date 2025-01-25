using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControlEnemy : MonoBehaviour
{
    [SerializeField] private Animator sword;
    private bool swordanimate;

    // Start is called before the first frame update
    void Start()
    {
        swordanimate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (swordanimate == true){
            sword.Play("swordSwing");
        }
        if(swordanimate == false){
            sword.Play("swordStop");
        }
        
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            swordanimate = true;


        }
    }
    void OnTriggerExit(Collider other){
        if (other.CompareTag("Player")){
            swordanimate = false;


        }
    }    
}
