using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogScript : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] bool _Idle;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Anim();
    }
    void Anim()
    {
        //_anim.SetBool("AndandoLateral", _AndandoLateral);
        //_anim.SetBool("AndandoVertical", _AndandoVertical);
        _anim.SetBool("Idle", _Idle);
    }
}
