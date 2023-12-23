using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTutorial : MonoBehaviour
{
    bool m_isTutorial;
    TutorialPanel m_ui;

    public void Start()
    {
        m_ui = FindObjectOfType<TutorialPanel>();
    }
    public bool IsTutorial()
    {
        return m_isTutorial;
    }
    public void SetTutorialPanel(bool state)
    {
        m_isTutorial = state;
    }
    void Update()
    {
        m_ui.ShowTutorialPanel(m_isTutorial);
    }
}
