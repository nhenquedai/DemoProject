using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    public GameObject Zombie;
    public float spawnTimeZombie;
    float m_spawnTimeZombie;
    bool m_isGameover;
    GameOverPanel m_ui;
    public void Start()
    {
        m_ui = FindObjectOfType<GameOverPanel>();
    }

    public void SpawnZ1()
    {
        UnityEngine.Vector3 randomSpawnPosition = new UnityEngine.Vector3(UnityEngine.Random.Range(78, 100), 0, UnityEngine.Random.Range(110, 126));
        Instantiate(Zombie, randomSpawnPosition, UnityEngine.Quaternion.identity);
    }

    public bool IsGameover()
    {
        return m_isGameover;
    }

    public void SetGameOver(bool state)
    {
        m_isGameover = state;
    }

    public void RePlay()
    {
        m_isGameover = false;
        m_ui.ShowGameOverPanel(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        m_spawnTimeZombie -= Time.deltaTime;
        if(m_isGameover)
        {
            m_spawnTimeZombie = 0;
            m_ui.ShowGameOverPanel(true);
            return;
        }
        if(m_spawnTimeZombie <= 0)
        {
            SpawnZ1();
            m_spawnTimeZombie = spawnTimeZombie;
        }
    }
}
