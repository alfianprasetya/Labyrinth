using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;
    [SerializeField] TMP_Text timerText;


    public void GameOver()
    {
        finishedText.text = "You Failed :(";
        finishedCanvas.SetActive(true);
    }

    public void PlayerWin()
    {
        finishedText.text = "You Win :) \n Time : " + timerText.text;
        finishedCanvas.SetActive(true);
    }
}
