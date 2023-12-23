using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWinterButton : MonoBehaviour
{
    public GameObject WinterButton;
    public float spawnTimeWB;
    float m_spawnTimeWB;
    private void Start()
    {
        m_spawnTimeWB = 20;
    }
    public void SpawnWB()
    {
        UnityEngine.Vector3 randomSpawnPosition = new UnityEngine.Vector3(UnityEngine.Random.Range(60, 120), 0, UnityEngine.Random.Range(60, 120));
        Instantiate(WinterButton, randomSpawnPosition, UnityEngine.Quaternion.identity);
    }
    void WinterButtonSpawn()
    {
        m_spawnTimeWB -= Time.deltaTime;
        if(m_spawnTimeWB <= 0)
        {
            SpawnWB();
            m_spawnTimeWB = spawnTimeWB;
        }
    }
    void Update()
    {
        WinterButtonSpawn();
    }
}
