using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score1p=0;
    public int score2p=0;
    Ball ball = GameObject.Find("ball").GetComponent<Ball>();

    public int[,] score1pMap = new int[5, 7] {  { 0,0,0,0,1,1,1 },
                                                { 0,0,0,0,1,0,1 },
                                                { 0,0,0,0,1,0,1 },
                                                { 0,0,0,0,1,0,1 },
                                                { 0,0,0,0,1,1,1 }
                                                };
    public int[,] score2pMap = new int[5, 7] {  { 0,0,0,0,1,1,1 },
                                                { 0,0,0,0,1,0,1 },
                                                { 0,0,0,0,1,0,1 },
                                                { 0,0,0,0,1,0,1 },
                                                { 0,0,0,0,1,1,1 }
                                                };
    void Awake()
    {
        instance = this;
        SpriteRenderer dot = GameObject.Find("Dot").GetComponent<SpriteRenderer>();
        for (int i = 0; i < score1pMap.GetLength(0); i++)
        {
            for (int j = 0; j < score1pMap.GetLength(0); j++)
            {
                SpriteRenderer dot1 = Instantiate(dot, new Vector3((2f + 0.4f * j), (4f - 0.4f * i), 0f), Quaternion.identity);
                dot1.name = "dot_1" + i+j;
            }
        }
        for (int i = 0; i < score2pMap.GetLength(0); i++)
        {
            for (int j = 0; j < score2pMap.GetLength(0); j++)
            {
                SpriteRenderer dot1 = Instantiate(dot, new Vector3((-2f - 0.4f * j), (4f - 0.4f * i), 0f), Quaternion.identity);
                dot1.name = "dot_2" + i + j;
            }
        }

    }
    public void scoreUp(int who)
    {
        if(who == 1)
        {
            score1p++;
        }else if (who == 2)
        {
            score2p++;
        }
    }

    private void Update()
    {
        for(int i = 0; i <  score1pMap.GetLength(0); i++)
        {
            for (int j = 0; j < score1pMap.GetLength(0); j++)
            {
                if(score1pMap[i, j] == 0)
                {

                }
            }
        }
    }
    public void Reset()
    {
        
    }

}
