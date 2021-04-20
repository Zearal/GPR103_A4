using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls2 : MonoBehaviour
{
    PlayerControls controls;
    Vector2 move;
    Vector2 rotate;
    public float speed = 10;
    Rigidbody2D rb;

    void Awake()
    {
        controls = new PlayerControls();
        controls.InGame.Movement.performed += ctx => SendMessage(ctx.ReadValue<Vector2>());
        controls.InGame.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.InGame.Movement.canceled += ctx => move = Vector2.zero;
        controls.InGame.Turning.performed += ctx => rotate = ctx.ReadValue<Vector2>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        controls.InGame.Enable();
    }
    private void OnDisable()
    {
        controls.InGame.Disable();
    }

    void SendMessage(Vector2 coordinates)
    {
        Debug.Log("Thumb-stick coordinates = " + coordinates);
    }

    void FixedUpdate()
    {
        //Moving player ship
        Vector2 movement = new Vector2(move.x, move.y) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        //Rotating player ship
        Vector3 turning = Vector3.left * rotate.x + Vector3.down * rotate.y; 
        Quaternion playerRotation = Quaternion.LookRotation(turning, Vector3.forward);
        rb.SetRotation(playerRotation);
    }
}