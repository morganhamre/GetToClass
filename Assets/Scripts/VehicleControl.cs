using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleControl : MonoBehaviour
{

    float speed;
    Vector2 direction = new Vector2();
    float moveDirection = 1;

    // Use this for initialization
    void Start()
    {
        speed = 2;
        direction.x = moveDirection;
        direction.y = 0;
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;

    }
}
