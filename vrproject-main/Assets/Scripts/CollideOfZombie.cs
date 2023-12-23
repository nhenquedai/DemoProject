using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideOfZombie : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            anim.SetBool("damage", true);
            anim.SetBool("death", true);
            Destroy(gameObject, 2);
        }
        if(other.gameObject.tag == "Player")
        {
            anim.SetBool("attack", true);
        }
        else
        {
            anim.SetBool("damage", false);
        }
    }
}
