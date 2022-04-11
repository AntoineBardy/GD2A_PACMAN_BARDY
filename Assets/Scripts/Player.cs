using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        Vector3 moveDirection = transform.position;

        if (Input.GetKey("z"))
        {
            moveDirection.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            moveDirection.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            moveDirection.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("q"))
        {
            moveDirection.x -= speed * Time.deltaTime;
        }

        transform.position = moveDirection;
    }
}
