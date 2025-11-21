using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sample;
using UnityEngine;

public class RewardSystem : MonoBehaviour
{
      [SerializeField] coin[] coins;
      private GhostScript _ghostscript;

      private UIControl uIControl;

    private void Start()
    {
        _ghostscript = FindAnyObjectByType<GhostScript>();
        uIControl = FindAnyObjectByType<UIControl>();
    }


    public void AddCoin()
    {
        DataContainer.coins++;
        if(DataContainer.coins >= coins.Length)
        {
            _ghostscript.LockInput();
            uIControl.FinishGame();
            
        }
    }

}



