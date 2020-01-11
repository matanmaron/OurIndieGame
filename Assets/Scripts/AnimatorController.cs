using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator animator;

    private Rigidbody2D m_Rigidbody2D;
    private CharacterController2D m_CharacterController2D;
    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        m_CharacterController2D = GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("HorizontalSpeed", Mathf.Abs(m_Rigidbody2D.velocity.x));
        animator.SetFloat("VerticalSpeed", m_Rigidbody2D.velocity.y);
        animator.SetBool("IsGrounded", m_CharacterController2D.IsGrounded());
    }
}
