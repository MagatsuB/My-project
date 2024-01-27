using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerControlle : MonoBehaviour
{
    [SerializeField] CharacterController _controller;

    [SerializeField] Sprite _sprVertical;
    [SerializeField] Sprite _sprLateral;
    [SerializeField] Sprite _sprIdle;

    [SerializeField] Animator _anim;
    [SerializeField] Vector2 _move;
    [SerializeField] Vector2 _movement;
    [SerializeField] float _speed;
    [SerializeField] bool _isFacingRight, _isFacingUp, _desfaz;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        //_anim = GetComponent<Animator>();
    }

    void Update()
    {
         Move();
         Anim();
         Direcao();
    }

    void Direcao()
    {
        /*if (math.abs(_move.x) > math.abs(_move.y))
        {
            transform.GetComponent<SpriteRenderer>().sprite = _sprLateral;
        }
        if (math.abs(_move.y) > math.abs(_move.x))
        {
            transform.GetComponent<SpriteRenderer>().sprite = _sprVertical;
        }
        if (_move.x == 0 && _move.y == 0)
        {
            transform.GetComponent<SpriteRenderer>().sprite = _sprIdle;
            //transform.localScale = Vector3.one;
        }*/

        if (_move.x > 0)
        {
            transform.GetComponent<SpriteRenderer>().sprite = _sprLateral;
        }
    }

    void Move()
    {
        _movement = new Vector3(_move.x, _move.y).normalized;
        _controller.Move(_movement * _speed * Time.deltaTime);
        

        if (_movement.x > 0 && _isFacingRight == true) 
        {
            FlipLeftRight();
        }
        else if(_movement.x < 0 && _isFacingRight == false)
        {
            FlipLeftRight();
        }
        if (_movement.y > 0 && _isFacingUp == true) 
        {
            FlipTopDown();
        }
        else if(_movement.y < 0 && _isFacingUp == false)
        {
            FlipTopDown();
        }
    }

    void Anim()
    {
       // float moveX = math.abs(_rb.velocity.x);
       // _anim.SetFloat("Correndo", moveX);
       // _anim.SetBool("CheckGround", _checkGround);
       // _anim.SetFloat("VelocidadePulo", _rb.velocity.y);
    }
    void FlipLeftRight()
    {
        _isFacingRight = !_isFacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }
    void FlipTopDown()
    {
        _isFacingUp = !_isFacingUp;

        Vector3 theScale = transform.localScale;
        theScale.y *= -1;
        transform.localScale = theScale;
        // Flip collider over the y-axis

    }

    public void SetMove(InputAction.CallbackContext value)
    {
        _move = value.ReadValue<Vector2>();
    }
    /*public void SetJump(InputAction.CallbackContext value)
    {
        Jump();
    }*/

    /*public void Iniciar()
    {
        _checkIni = true;
    }*/

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _checkGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _checkGround = false;
        }
    }*/


}
