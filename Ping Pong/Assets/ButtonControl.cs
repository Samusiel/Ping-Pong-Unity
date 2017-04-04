using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour {

    private Button m_button;
    private Ball m_ballComponent;

    void Start()
    {
        m_ballComponent = GameObject.Find("Sphere").gameObject.GetComponent<Ball>();
    }

    public void onClick()
    {        
        m_ballComponent.BeginGame();
    }
}
