using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15f;// Speed at which the paddle moves
    public float topHeight;// Top limit of the paddle's movement
    public float botHeight;// Bottom limit of the paddle's movement
    public bool useArrowKeys = false;// If true, use arrow keys; if false, use W and S keys
    void Update()
    {
        MovePaddle();
    }
    void MovePaddle()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, ConstrainPaddle(), this.gameObject.transform.position.z);
    }
    float ConstrainPaddle()
    {
        float nuevaY = this.gameObject.transform.position.y + (PaddleDirection() * moveSpeed * Time.deltaTime);
        if (nuevaY > topHeight)
        {
            nuevaY = topHeight;
        }
        if (nuevaY < botHeight)
        {
            nuevaY = botHeight;
        }
        return nuevaY;
    }
    float PaddleDirection()
    {
        float direccion = 0f;

        if (useArrowKeys == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                direccion = -1f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                direccion = -1f;
            }
        }
        return direccion;
    }
}
