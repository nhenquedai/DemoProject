using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    public void Play()
    {
            Time.timeScale = 1f;
            Application.LoadLevel("SampleScene");
    }
}
