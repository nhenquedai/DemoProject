using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGate : MonoBehaviour
{
    public GameObject Gate;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(Gate, 30);
    }
}
