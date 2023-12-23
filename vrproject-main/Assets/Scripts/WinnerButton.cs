using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerButton : MonoBehaviour
{
    public GameObject Star;
    public float spawnTimeStar;
    float m_spawnTimeStar;
    bool isWork;
    private void Start()
    {
        m_spawnTimeStar = 0;
    }
    public void SpawnStar()
    {
        UnityEngine.Vector3 randomSpawnPosition = new UnityEngine.Vector3(UnityEngine.Random.Range(60, 120), 0, UnityEngine.Random.Range(60, 120));
        Instantiate(Star, randomSpawnPosition, UnityEngine.Quaternion.identity);
    }
    private Animator _buttonAnimator;
    void Awake()
    {
        _buttonAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hand")
        {
            _buttonAnimator.SetBool("ButtonPressed", true);
            m_spawnTimeStar -= Time.deltaTime;
            if(m_spawnTimeStar <= 0)
            {
                SpawnStar();
                m_spawnTimeStar = spawnTimeStar;
            }
        }
    }
}
