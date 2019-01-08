using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score1p=0;
    public int score2p=0;

    void Awake()
    {
        instance = this;
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


}
