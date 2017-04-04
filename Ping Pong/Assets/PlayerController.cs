using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : UnityEngine.Networking.NetworkBehaviour
{
    private float m_prevPos = 0;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(9.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }

        float speed = 0.15f;

        float step = Input.GetAxis("Horizontal") * speed;
        m_prevPos += step;
        if (m_prevPos >= 8.0f || m_prevPos <= -8.0f)
        {
            m_prevPos -= step;
            step = 0;
        }

        transform.Translate(0, step, 0);
    }
}
