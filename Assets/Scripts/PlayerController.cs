using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;

    private Rigidbody2D rb;
    private Animator myAnim;
    private Vector2 movementDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        myAnim.SetFloat("moveX", rb.velocity.x);
        myAnim.SetFloat("moveY", rb.velocity.y);
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
