using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWinnerButton : MonoBehaviour
{
    public GameObject WinterButton;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(WinterButton, 30);
    }
}
