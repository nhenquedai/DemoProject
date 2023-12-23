using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayButton : MonoBehaviour
{
    public void Replay()
    {
        Application.LoadLevel("SampleScene");
        Time.timeScale = 1f;
    }
}
