using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public float turnSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(10 * x * turnSpeed * Time.deltaTime, 0, speed * Time.deltaTime);
    }
}
