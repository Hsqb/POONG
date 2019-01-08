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
        float y = transform.position.y + Input.GetAxisRaw("1P_Vertical") * Time.deltaTime * moveSpeed;
        y = y > 4.5f ? 4.5f : y;
        y = y < -4.5f ? -4.5f : y;
        transform.position = new Vector2(transform.position.x, y);
    }
}