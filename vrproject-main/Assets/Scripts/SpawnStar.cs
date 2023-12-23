using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStar : MonoBehaviour
{
    public GameObject Star;
    public float spawnTimeStar;
    float m_spawnTimeStar;
    public void SpawnS()
    {
        UnityEngine.Vector3 randomSpawnPosition = new UnityEngine.Vector3(UnityEngine.Random.Range(60, 120), 20, UnityEngine.Random.Range(60, 120));
        Instantiate(Star, randomSpawnPosition, UnityEngine.Quaternion.identity);
    }

    void Update()
    {
        m_spawnTimeStar -= Time.deltaTime;
        if(m_spawnTimeStar <= 0)
        {
            SpawnS();
            m_spawnTimeStar = spawnTimeStar;
        }
    }
}
