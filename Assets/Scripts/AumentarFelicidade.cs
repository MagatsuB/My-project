using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarFelicidade : MonoBehaviour
{
    MedidorFelicidade medidorFelicidade;
    [SerializeField] bool _aumentou;
    void Start()
    {
        medidorFelicidade = Camera.main.GetComponent<MedidorFelicidade>();
        _aumentou = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 13)
        {
            if (!_aumentou)
            {
                Debug.Log("passou aqui");
                medidorFelicidade.FicouFeliz();
                _aumentou=true;
            }
        }
    }
}
