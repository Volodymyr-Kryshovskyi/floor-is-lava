using System.Collections;
using System.Collections.Generic;
using Sample;
using UnityEngine;

public class LavaDeathProcess : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GhostScript ghost = other.GetComponent<GhostScript>();

        if (ghost != null)
        {
            ghost.Damage();
        }
    }
}

