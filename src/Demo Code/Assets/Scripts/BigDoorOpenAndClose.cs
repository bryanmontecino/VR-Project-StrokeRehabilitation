using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //[SerializeField] private bool alreadyDone = false;
    private bool istrigger = false; 
    [SerializeField] private Animator myDoor = null; 
    //[SerializeField] private bool openTrigger = false; 
    //[SerializeField] private bool closeTrigger = false; 
    
 
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            if (!istrigger) { 
                myDoor.Play("BigDoorOpen", 0, 0.0f); 
                istrigger = true;    
            }
            else {
                myDoor.Play("BigDoorClose", 0, 0.0f);
                istrigger = false;
            }   
        }
        
    }
}

