using System.Collections;
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

    public void Speech(Sprite _p, string[] _txt, string _nomedoElemento)
    {
        _dialogueObj.SetActive(true);
        _profile.sprite = _p;
        //_falas.text = _txt;
        _sentences = _txt;
        _nomedoElementoText.text = _nomedoElemento;
        StartCoroutine(TypeSentence());


    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in _sentences[index].ToCharArray)
        {
            _falas.text += letter;
            yield return new WaitForSeconds(_textvelocity);

        }
    }

    public void NextSentence()
    {
        if (_falas.text == _sentences[index])
        {

            if (index < _sentences.Length - 1)
            {
                index++;
                _falas.text = "";
                StartCoroutine(TypeSentence());
            }
        }
        else
        {
            _falas.text = "";
            index = 0;
            _dialogueObj.SetActive(false);
        }
    }


}
