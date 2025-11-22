using System.Collections;
using System.Collections.Generic;
using Sample;
using UnityEngine;

public class LavaDeathProcess : MonoBehaviour
{

    private GhostScript _ghostscript;
    private void OnTriggerEnter(Collider other)
    {
        if(_ghostscript = other.GetComponent<GhostScript>()) {
            _ghostscript.Damage();
        }
            
        

    } 
}

