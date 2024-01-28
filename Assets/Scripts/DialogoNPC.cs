using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoNPC : MonoBehaviour
{
    public Sprite _profile;
    public string[] _falastxt;
    public string _NomeNPC;

    public LayerMask _playerLayer;
    public float _radious;

    public DialogueControl _dialogueControl;
    [SerializeField] bool _onRadious;

    private void Start()
    {
        _dialogueControl = FindObjectOfType<DialogueControl>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==13){

            _onRadious = true;
            Camera.main.GetComponent<ControlDialogo>()._dialogoNPC = GetComponent<DialogoNPC>();
            Camera.main.GetComponent<ControlDialogo>()._dialogo.SetActive(true);
            Camera.main.GetComponent<ControlDialogo>()._bts[0].SetActive(true);
            Camera.main.GetComponent<ControlDialogo>()._bts[1].SetActive(false);
            Camera.main.GetComponent<ControlDialogo>().TextDialogo(0);
            //_dialogueControl.Speech(_profile, _falastxt[0], _NomeNPC);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 13)
        {
            _onRadious = false;
            Camera.main.GetComponent<ControlDialogo>()._dialogo.SetActive(false);
            Camera.main.GetComponent<ControlDialogo>()._dialogoNPC = null;

          //  _dialogueControl = collision.GetComponent<DialogueControl>();
          //  _dialogueControl.DialogueObjOff();
        }
    }
}
