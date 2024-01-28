using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerControlle : MonoBehaviour
{
    [SerializeField] CharacterController _controller;
    [SerializeField] Rigidbody2D _rb2d;

    [SerializeField] GameObject[] _carro;
    [SerializeField] Transform _carSpawner, _carSpawner2;

    [SerializeField] Sprite _sprVertical;
    [SerializeField] Sprite _sprLateral;
    [SerializeField] Sprite _sprIdle;

    [SerializeField] Animator _anim;
    [SerializeField] Vector2 _move;
    [SerializeField] Vector2 _movement;
    [SerializeField] float _speed;
    [SerializeField] float _aceleracaoCarro;
    [SerializeField] bool _isFacingRight, _isFacingUp, _desfaz;
    [SerializeField] bool _AndandoLateral, _AndandoVertical, _Idle;


    void Start()
    {
        //_controller = GetComponent<CharacterController>();
        _anim = GetComponent<Animator>();
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Anim();
        Move();
        Direcao();
    }

    void Direcao()
    {
        if (math.abs(_move.x) > math.abs(_move.y))
        {
            //transform.GetComponent<SpriteRenderer>().sprite = _sprLateral;
            _AndandoLateral = true;
            _AndandoVertical = false;
            _Idle = false;
        }
        
        if (math.abs(_move.y) > math.abs(_move.x))
        {
            //transform.GetComponent<SpriteRenderer>().sprite = _sprVertical;
            _AndandoVertical = true;
            _AndandoLateral = false;
            _Idle = false;
        }
        
        if (_move.x == 0 && _move.y == 0)
        {
            //transform.GetComponent<SpriteRenderer>().sprite = _sprIdle;
            _AndandoVertical = false;
            _AndandoLateral = false;
            _Idle = true;
            //transform.localScale = Vector3.one;
        }
    }

    void Move()
    {
        _movement = new Vector3(_move.x, _move.y);
        _rb2d.velocity = _movement * _speed;
        //_controller.Move(_movement * _speed * Time.deltaTime);
        

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
        //else if(_movement.y < 0 && _isFacingUp == false)
        {
          //  FlipTopDown();
        }
    }

    void Anim()
    {
       _anim.SetBool("AndandoLateral", _AndandoLateral);
       _anim.SetBool("AndandoVertical", _AndandoVertical);
       _anim.SetBool("Idle", _Idle);
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

    void Carro1()
    {
            
            Instantiate(_carro[0], _carSpawner, false);
            _carro[0].SetActive(true);
    }
    void Carro2()
    {
            Instantiate(_carro[1], _carSpawner2, false);
            _carro[1].SetActive(true);
    }

    public void SetMove(InputAction.CallbackContext value)
    {
        _move = value.ReadValue<Vector2>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CarTrigger"))
        {
            Invoke("Carro1", 2f);
        }
        if (collision.gameObject.CompareTag("CarTriggerRoxo"))
        {
            Invoke("Carro2", 1.5f);
        }
    }
}
