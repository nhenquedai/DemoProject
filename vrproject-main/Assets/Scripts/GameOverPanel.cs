using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
    public GameObject gameoverPanel;

    public void ShowGameOverPanel(bool isShow)
    {
        if(gameoverPanel)
        {
            gameoverPanel.SetActive(isShow);
            Time.timeScale = 0f;
        }
    }
}
