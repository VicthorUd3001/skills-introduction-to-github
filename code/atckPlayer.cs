using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atckPlayer : MonoBehaviour
{
    [SerializeField] private Animator atck;
    private bool attackAnimate;

    // Start is called before the first frame update
    void Start()
    {
        attackAnimate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (attackAnimate == true){
            atck.Play("hamAnim");
        }
        if(attackAnimate == false){
            atck.Play("hamStop");
        }
        
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("enemy")){
            attackAnimate = true;
        }
    }
    void OnTriggerExit(Collider other){
        if (other.CompareTag("enemy")){
            attackAnimate = false;
        }
    }
}
