using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class pickup1 : MonoBehaviour
{
    // make sure that you attach an empty object as a child to your player, and use that as your assigned "guide" for where objects that are picked up should go.
    // All pickup objects require the "pickup" tag, and a trigger only box collider, in order to function properly.
    public float speed = 10;
    public bool canHold = true;
    public static GameObject pickupItem;
    public Transform guide;
    public Transform hamGuide;
    public int numForIt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            if (!canHold){
                throw_drop();
            }
            else{
                pickupPlease();
            }
        }   
        if (!canHold && pickupItem){
            pickupItem.transform.position = guide.position;
        } 
        if (numForIt > 0)
        {
            guide = hamGuide;
        }
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="pickup"){
            if(!pickupItem){
                pickupItem = col.gameObject;
            }
        }
    }
    void OnTriggerExit (Collider col){
        if (col.gameObject.tag=="pickup"){
            if(canHold){
                pickupItem = null;
            }
        }
    }

    private void pickupPlease(){
        if(!pickupItem)
        return;
        
        pickupItem.transform.SetParent(guide);
        pickupItem.GetComponent<Rigidbody>().useGravity = false;
        pickupItem.transform.localRotation = transform.rotation;
        pickupItem.transform.position = guide.position;
        canHold = false;
        Debug.Log("CanHold on" + canHold);

    }

    public void throw_drop(){
        if(!pickupItem)
        return;
        
        pickupItem.transform.parent = null;
        pickupItem.GetComponent<Rigidbody>().useGravity = true;
        pickupItem = null;
        guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        canHold = true;
    }
}