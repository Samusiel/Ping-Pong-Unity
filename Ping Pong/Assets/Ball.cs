using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    float m_sx;
    float m_sy;

    GameObject m_player1;
    GameObject m_player2;

    // Use this for initialization
    void Start () {
        //-- Get Players
        m_player1 = GameObject.Find("Player1");
        m_player2 = GameObject.Find("Player2");
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < m_player1.transform.position.x)
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);

            GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);

            //-- Setting directions
            m_sx = 0.0f;
            m_sy = 0.0f;
        }            
    }

    public void BeginGame() {
        //-- Set the speed of the ball
        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(5, 10), Random.Range(5, 10), 0.0f);

        //-- Setting directions
        m_sx = Random.Range(0, 2) == 0 ? -1.0f : 1.0f;
        m_sy = Random.Range(0, 2) == 0 ? -1.0f : 1.0f;
    }
}
