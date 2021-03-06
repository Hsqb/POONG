﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float direction;
    public float ballSpeed = 7;
    public float grade;
    public float b;
    public bool isGaming = true;
    // Start is called before the first frame update
    void Start()
    {
        direction = -1;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(direction+":"+ballSpeed+":"+ Time.deltaTime);
        if (isGaming)
        {
            float x = transform.position.x + (direction * ballSpeed * Time.deltaTime);
            transform.position = new Vector2(x, b + (x * grade));
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log(coll.gameObject.tag);
        if(coll.gameObject.tag == "updown_wall"){
            grade *= -1;
            b = coll.contacts[0].point.y - ( grade * coll.contacts[0].point.x);
        } else if(coll.gameObject.tag == "1p_goal" || coll.gameObject.tag == "2p_goal")
        {
            if (coll.gameObject.tag == "1p_goal")
            {
                GameManager.instance.scoreUp(2);
                direction = 1f;
            }
            else if (coll.gameObject.tag == "2p_goal")
            {
                GameManager.instance.scoreUp(1);
                direction = -1f;
            }
            grade = 0f;
            b = 0f;
            transform.position = new Vector2(0, 0);
            Debug.Log(coll.gameObject.ToString());

        }
        else{
            direction *= -1;
            //Debug.Log("ball  OnCollisionEnter");
            grade = (coll.gameObject.transform.position.y - coll.contacts[0].point.y) /
            (coll.gameObject.transform.position.x - coll.contacts[0].point.x);
            if(grade > 1.5){
                grade = 1.5f;
            }else if(grade < -1.5){
                grade = -1.5f;
            }
            b = coll.contacts[0].point.y - ( grade * coll.contacts[0].point.x);
           // Debug.Log("grade : " +grade);
        }
    }
}
