using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float direction;
    public float ballSpeed = 0.15F;
    public float grade;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        direction = -1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = GetNewPosition();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject.tag);
        if(coll.gameObject.tag == "updown_wall"){
            grade *= -1;
            b = coll.contacts[0].point.y - ( grade * coll.contacts[0].point.x);
        } else if(coll.gameObject.tag == "goal"){
            Debug.Log("goal!");
        }else{
            direction *= -1;
            Debug.Log("ball  OnCollisionEnter");
            grade = (coll.gameObject.transform.position.y - coll.contacts[0].point.y) /
            (coll.gameObject.transform.position.x - coll.contacts[0].point.x);
            if(grade > 1.5){
                grade = 1.5f;
            }else if(grade < -1.5){
                grade = -1.5f;
            }
            b = coll.contacts[0].point.y - ( grade * coll.contacts[0].point.x);
            Debug.Log("grade : " +grade);
        }
    }
    Vector2 GetNewPosition()
    {
        float x = transform.position.x + (direction * ballSpeed);
        return new Vector2( x , b + (x * grade));
    }
}

