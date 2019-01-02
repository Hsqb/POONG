using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    int score1p;
    int score2p;
    // Start is called before the first frame update
    void Start()
    {
        score1p = 0;
        score2p = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject ball = GameObject.Find("Ball");
        ball.transform.position = new Vector2(0, 0);
        Ball b = ball.GetComponent<Ball>();

        b.grade = 0f;
        b.b = 0f;

        if (ToString() == "1p_goal (Table)")
        {
            score2p++;
            b.direction = 1f;
        }
        else if (ToString() == "2p_goal (Table)")
        {
            score1p++;
            b.direction = -1f;
        }
        Debug.Log(score1p +" : "+score2p);
        
    }
}
