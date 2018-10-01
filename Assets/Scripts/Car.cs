using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
    float speed;
    Vector2 direction = new Vector2();
    float moveDirection;

    // Use this for initialization
    void Start()
    {
        speed = 2;
        direction.x = 1;
        direction.y = 0;
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;

    }
}
