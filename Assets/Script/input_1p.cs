using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_1p : MonoBehaviour
{
    float moveSpeed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("1P_Vertical") * Time.deltaTime * moveSpeed;
        transform.position = new Vector3(transform.position.x, transform.position.y + h, transform.position.z);
    }
    void OnCollisionEnter2D()
    {
        Debug.Log("1p OnCollisionEnter");
    }
}