using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private TMP_Text coins;
    [SerializeField] private TMP_Text deaths;

    void Update()
    {
        coins.text = DataContainer.coins.ToString();
        deaths.text  = DataContainer.deaths.ToString();

    }
}
