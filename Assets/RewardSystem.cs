using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RewardSystem : MonoBehaviour
{
      [SerializeField] coin[] coins;

      private UIControl uIControl;

    private void Start()
    {
        uIControl = FindAnyObjectByType<UIControl>();
    }


    public void AddCoin()
    {
        DataContainer.coins++;
        if(DataContainer.coins >= coins.Length)
        {
            uIControl.FinishGame();
        }
    }

}



