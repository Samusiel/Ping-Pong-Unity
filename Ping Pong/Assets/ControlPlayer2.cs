using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer2 : MonoBehaviour
{

    private float m_prevPos;

    // Use this for initialization
    void Start()
    {
        m_prevPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.15f;

        float step = Input.GetAxis("Vertical") * speed;
        m_prevPos += step;
        if (m_prevPos >= 8.0f || m_prevPos <= -8.0f)
        {
            m_prevPos -= step;
            step = 0;
        }

        transform.Translate(0, step, 0);
    }
}
