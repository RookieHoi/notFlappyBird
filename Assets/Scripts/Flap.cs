using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) rBody.velocity = Vector2.up * velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
