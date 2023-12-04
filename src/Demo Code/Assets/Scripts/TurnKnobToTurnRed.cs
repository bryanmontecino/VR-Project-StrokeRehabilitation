using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnStoveTopRed : MonoBehaviour
{
    [SerializeField] private Color startColor;
    [SerializeField] private Color endColor; 
    [SerializeField] private Renderer objectRenderer; 
    [SerializeField] private Animator myKnob = null; 


    private bool istrigger = false; 

    float t = 0; 

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player")) {
            if (!istrigger) { 
                myKnob.Play("StoveKnobOn", 0, 0.0f); 
                objectRenderer.material.SetColor("_Color", endColor);
                istrigger = true;    
            }
            else {
                myKnob.Play("StoveKnobClose", 0, 0.0f);
                objectRenderer.material.SetColor("_Color", startColor);
                istrigger = false;
            }
            //objectRenderer.material.SetColor("_Color", endColor);
        }
         
    }
}
