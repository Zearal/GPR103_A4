using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;
    Vector2 move;
    Vector2 rotate;
    public float speed = 5f;
    bool boostActive = false;
    bool boostCooldown = false;
    Rigidbody2D rb;
    bool boosterActive;
    public GameObject booster1;
    public GameObject booster2;
    void Awake()
    {
        controls = new PlayerControls();
        //controls.InGame.Movement.performed += ctx => SendMessage(ctx.ReadValue<Vector2>());
        controls.InGame.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.InGame.Movement.canceled += ctx => move = Vector2.zero;
        controls.InGame.Turning.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.InGame.Boost.performed += ctx => Boost();
        controls.InGame.Utility.performed += ctx => boosterActive = true;
        controls.InGame.Utility.performed += ctx => Booster();
        controls.InGame.Utility.canceled += ctx => boosterActive = false;
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
    //void SendMessage(Vector2 coordinates)
    //{
    //    Debug.Log("Thumb-stick coordinates = " + coordinates);
    //}
    void Boost()
    {
        if(boostActive == false && boostCooldown == false)
        {
            boostActive = true;
            boostCooldown = true;
            StartCoroutine(BoostActive());
            StartCoroutine(BoostCooldown());
        }
    }
    IEnumerator BoostCooldown()
    {
        boostCooldown = true;
        yield return new WaitForSeconds(15f);
        boostCooldown = false;
    }
    IEnumerator BoostActive()
    {
        boostActive = true;
        yield return new WaitForSeconds(5f);
        boostActive = false;
    }
    void Booster()
    {
        if (boosterActive == true)
        {
            speed = 10f;
            booster1.SetActive(true);
            booster2.SetActive(true);
        }
    }
    void FixedUpdate()
    {
        //Moving player ship
        if (boostActive == true)
        {
            rb.velocity = new Vector2(move.x, move.y) * speed * 2;
            //Vector2 movement = new Vector2(move.x, move.y) * speed * 2 * Time.deltaTime;
            //transform.Translate(movement, Space.World);
        }
        else
        {
            rb.velocity = new Vector2(move.x, move.y) * speed;
            //Vector2 movement = new Vector2(move.x, move.y) * speed * Time.deltaTime;
            //transform.Translate(movement, Space.World);
        }
        //Rotating player ship
        Vector3 turning = Vector3.left * rotate.x + Vector3.down * rotate.y;
        Quaternion playerRotation = Quaternion.LookRotation(turning, Vector3.forward);
        rb.SetRotation(playerRotation); 

        //booster update
        if(boosterActive == false)
        {
            speed = 5f;
            booster1.SetActive(false);
            booster2.SetActive(false);
        }
    }
}