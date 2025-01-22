using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float movespeed = 5.0f;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal, 0, 0);

        transform.position += movespeed * Time.deltaTime * movement;
    }
}
