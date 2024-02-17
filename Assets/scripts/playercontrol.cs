using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    [SerializeField] float torqueAmount = 10f;
    [SerializeField] float basespeed = 22.5f;
    [SerializeField] float boostspeed = 33f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceeffector2D;
    bool canmove = true;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceeffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canmove)
        {
            Rotateplayer();
            Boostplayer();
        }

    }

    public void DisableControls()
    {
        canmove = false;
    }

    void Boostplayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            surfaceeffector2D.speed = boostspeed;
        }
        else
        {
            surfaceeffector2D.speed = basespeed;
        }

    }

    void Rotateplayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
