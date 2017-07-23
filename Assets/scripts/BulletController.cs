﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy") {
            collision.gameObject.SendMessage ("Die");
        }
        Destroy (gameObject);
    }
}
