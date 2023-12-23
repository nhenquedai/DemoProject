using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTutorial : MonoBehaviour
{
    public SetTutorial m_gc;

    private void Start()
    {
        m_gc = FindObjectOfType<SetTutorial>();
    }
    public void Open()
    {
        m_gc.SetTutorialPanel(true);
    }
}
