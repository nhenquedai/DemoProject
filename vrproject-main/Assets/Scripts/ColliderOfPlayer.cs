using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOfPlayer : MonoBehaviour
{
    SpawnZombie m_gc;

    private void Start()
    {
        m_gc = FindObjectOfType<SpawnZombie>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Gate")
        {
            Time.timeScale = 1f;
            Application.LoadLevel("MenuScene");
        }
        if(other.gameObject.tag == "KillPlayer")
        {
            m_gc.SetGameOver(true);
        }
    }
}
