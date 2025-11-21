using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    [SerializeField] private TMP_Text coins;
    [SerializeField] private TMP_Text deaths;
    [SerializeField]private GameObject winnerUi;
    [SerializeField] private GameObject restartUi;

    void Update()
    {
        coins.text = DataContainer.coins.ToString();
        deaths.text  = DataContainer.deaths.ToString();

                
        
    }

    public void FinishGame()
    {
        winnerUi.SetActive(true);
        restartUi.SetActive(true);
    }

        public void RestartGame()
    {
        
        DataContainer.coins = 0;
        DataContainer.deaths = 0;

        
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }


}
