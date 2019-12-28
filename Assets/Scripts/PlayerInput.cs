using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    public CharacterController2D CharacterController2D;


    void FixedUpdate()
    {
        
        CharacterController2D.Move(Input.GetAxis("Horizontal"), 
            Input.GetKeyDown(KeyCode.C), 
            Input.GetKeyDown(KeyCode.Space));
        
    }
}
