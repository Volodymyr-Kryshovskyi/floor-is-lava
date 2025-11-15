using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private TMP_Text coins;

    void Update()
    {
        coins.text = DataContainer.coins.ToString();
    }
}
