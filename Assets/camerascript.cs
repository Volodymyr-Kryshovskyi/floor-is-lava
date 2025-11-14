using System.Collections;
using System.Collections.Generic;
using Sample;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    private Transform ghostTransform;

    // [SerializeField] private float cameraspeed;

    private void Start()
    {
        ghostTransform = FindAnyObjectByType<GhostScript>().transform;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(ghostTransform.position.x, transform.position.y, ghostTransform.position.z ) , 200f);
    }


}