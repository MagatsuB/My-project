using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDialogo : MonoBehaviour
{
    public DialogoNPC _dialogoNPC;
    public Text _textNPC;
    public Text _textNomeNPC;
    public Image _img;
    public int _index;
    public GameObject _dialogo;

    public GameObject[] _bts;


    public void TextDialogo(int value)
    {
        _textNPC.text = _dialogoNPC._falastxt[value];
        _textNomeNPC.text = _dialogoNPC._NomeNPC;
        _img.sprite = _dialogoNPC._profile;
    }

    public void TextDialogoFechar()
    {
        _index = 0;
        _dialogo.SetActive(false);
    }


    public void AvancarBT()
    {
        if(_index < _dialogoNPC._falastxt.Length-1)
        {
            _index++;
            TextDialogo(_index);
           
        }
        else
        {
            _bts[0].SetActive(false);
            _bts[1].SetActive(true);
        }
        
    }
}
