using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
     RewardSystem _rewardSystem ;
    [SerializeField] private float RotateSpeed = 200f;

    private void Start()
    {
        _rewardSystem = GetComponentInParent<RewardSystem>();
    }
    private void Update()
    {
        transform.Rotate(200*Time.deltaTime, 0 , 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        _rewardSystem.AddCoin();
        Destroy(gameObject);
    }
}
