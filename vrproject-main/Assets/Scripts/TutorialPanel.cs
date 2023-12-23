using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPanel : MonoBehaviour
{
    public GameObject tutorialPanel;
    public void ShowTutorialPanel(bool isShowT)
    {
        if(tutorialPanel)
        {
            tutorialPanel.SetActive(isShowT);
        }
    }
}
