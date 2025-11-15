using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    [SerializeField] private float RotateSpeed = 200f;
    private void Update()
    {
        transform.Rotate(200*Time.deltaTime, 0 , 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        DataContainer.coins++;
        Destroy(gameObject);
    }
}
