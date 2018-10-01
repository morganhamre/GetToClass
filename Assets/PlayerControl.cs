using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigidbod;
    public float step;

    // Use this for initialization
    void Start()
    {
        rigidbod = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = rigidbod.position;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos.y += step;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            pos.x -= step;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            pos.x += step;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            pos.y -= step;
        }

        rigidbod.position = pos;
    }
}
