using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public SetTutorial m_gc;
    private void Start()
    {
        m_gc = FindObjectOfType<SetTutorial>();
    }
    public void Close()
    {
        m_gc.SetTutorialPanel(false);
    }
}
