using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : UnityEngine.Networking.NetworkBehaviour
{

    private float m_sx;
    private float m_sy;

    private GameObject m_player1;
    private GameObject m_player2;

    private Text m_player1ScoreText;
    private Text m_player2ScoreText;

    private int m_player1Score = 0;
    private int m_player2Score = 0;

    // Use this for initialization
    void Start () {
        //-- Get Players
        m_player1 = GameObject.Find("Player1");
        m_player2 = GameObject.Find("Player2");

        //-- Get Scores Texts
        m_player1ScoreText = GameObject.Find("Player1Score").gameObject.GetComponent<Text>();
        m_player2ScoreText = GameObject.Find("Player2Score").gameObject.GetComponent<Text>();

        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < m_player1.transform.position.x)
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            Reset(new Vector3(0.0f, 0.0f, 0.0f), 0.0f, 0.0f);
            ++m_player2Score;
            m_player2ScoreText.text = "Score: " + m_player2Score;
        } 
        else if (transform.position.x > m_player2.transform.position.x)
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            Reset(new Vector3(0.0f, 0.0f, 0.0f), 0.0f, 0.0f);
            ++m_player1Score;
            m_player1ScoreText.text = "Score: " + m_player1Score;
        }   
    }

    public void BeginGame() {
        //-- Set the speed of the ball and direction
        Reset(
            new Vector3(Random.Range(5, 10), Random.Range(5, 10), 0.0f),
            Random.Range(0, 2) == 0 ? -1.0f : 1.0f,
            Random.Range(0, 2) == 0 ? -1.0f : 1.0f);
    }

    private void Reset(Vector3 velocity, float sx, float sy)
    {
        GetComponent<Rigidbody>().velocity = velocity;

        m_sx = sx;
        m_sy = sy;
    }
}
