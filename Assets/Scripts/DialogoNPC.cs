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

    private DialogueControl _dialogueControl;
    bool _onRadious;

    private void Start()
    {
        _dialogueControl = FindObjectOfType<DialogueControl>();
    }

    private void FixedUpdate()
    {
        Interact();
    }

    private void Update()
    {
        if (_onRadious && Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("ChamouOSpeech");
            _dialogueControl.Speech(_profile, _falastxt, _NomeNPC);
        }
    }

    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, _radious, _playerLayer);
        
        if (hit != null)
        {
            _onRadious = true;
        }
        else
        {
            _onRadious= false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, _radious);
    }
}
