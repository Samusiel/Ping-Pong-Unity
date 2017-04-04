using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer2 : MonoBehaviour
{

    private float m_prevPos;

    // Use this for initialization
    void Start()
    {
        m_prevPos = 0;
        transform.position = new Vector3(9.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //float speed = 0.15f;
        //
        //float step = Input.GetAxis("Vertical") * speed;
        //m_prevPos += step;
        //if (m_prevPos >= 8.0f || m_prevPos <= -8.0f)
        //{
        //    m_prevPos -= step;
        //    step = 0;
        //}
        //
        //transform.Translate(0, step, 0);
    }
}
