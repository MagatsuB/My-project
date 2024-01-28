using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject _dialogueObj;
    public Image _profile;
    public Text _falas;
    public Text _nomedoElementoText;

    [Header("Settings")]
    public float _textvelocity;
    private string[] _sentences;
    private int index;
    public GameObject[] _bts;


    public void Speech(Sprite _p, string _txt, string _nomedoElemento)
    {
        _dialogueObj.SetActive(true);
        _profile.sprite = _p;
        _falas.text = _txt;
        //_sentences = _txt;
        _nomedoElementoText.text = _nomedoElemento;
        _bts[0].SetActive(true);
        _bts[1].SetActive(false);
      //  StartCoroutine(TypeSentence());

    }

    public void DialogueObjOff()
    {
        _dialogueObj.SetActive(false);
        index = 0;
        _falas.text = _sentences[index];
       // StartCoroutine(TypeSentence());
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in _sentences[index].ToCharArray())
        {
            _falas.text += letter;
            yield return new WaitForSeconds(_textvelocity);
        }
    }

    public void NextSentence()
    {
     //   _falas.text = _dialogueObj;
        index++;
        if (index >= _sentences.Length)
        {
            
        }
        else
        {
           
        }
    }




}
