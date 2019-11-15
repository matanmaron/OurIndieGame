using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //publics
    [SerializeField] private CharacterController2D _characterController2D;
    [SerializeField] private float runSpeed = 40;

    //privets
    private float moveHorizontal = 0;
    private bool isJump = false;

    void Start()
    {
        
    }

    void Update()
    {
        //player control
        moveHorizontal = Input.GetAxisRaw("Horizontal") * runSpeed;
        isJump = Input.GetButtonDown("Jump");
    }

    private void LateUpdate()
    {
       //camera movement
    }

    private void FixedUpdate()
    {
        //Physics and collisions
        PlayerMovmentHandler();
    }

    private void PlayerMovmentHandler()
    {
        _characterController2D.Move(moveHorizontal * Time.fixedDeltaTime, false, isJump);
    }
}
