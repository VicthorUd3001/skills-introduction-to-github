using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearAtck : MonoBehaviour
{
    [SerializeField] private Animator atck;
    private bool spearAnimate;

    // Start is called before the first frame update
    void Start()
    {
        spearAnimate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (spearAnimate == true){
            atck.Play("spearAtck");
        }
        if(spearAnimate == false){
            atck.Play("spearStop");
        }
        
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("enemy")){
            spearAnimate = true;
        }
    }
    void OnTriggerExit(Collider other){
        if (other.CompareTag("enemy")){
            spearAnimate = false;
        }
    }
}
