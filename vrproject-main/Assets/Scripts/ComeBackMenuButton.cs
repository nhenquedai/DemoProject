using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeBackMenuButton : MonoBehaviour
{
    public void ComeBackMenu()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("MenuScene");
    }
}
