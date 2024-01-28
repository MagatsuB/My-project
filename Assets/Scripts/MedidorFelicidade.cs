using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedidorFelicidade : MonoBehaviour
{
    [SerializeField] List<GameObject> _barrasFelicidade;

    public int _felicidadeAtual, _felicidadeMáxima, _valorAnterior;

    void Start()
    {
        _felicidadeMáxima = 5;
        _felicidadeAtual = 0;
        _valorAnterior = _felicidadeAtual;
    }

    
    void Update()
    {
        if (_felicidadeAtual != _valorAnterior)
        {
            FelicidadeCheck();
            _valorAnterior = _felicidadeAtual;
        }
    }

    public void FicouFeliz()
    {
        _felicidadeAtual += 1;
    }

    public void FelicidadeCheck()
    {
        if (_felicidadeAtual > 5)
        {
            _felicidadeAtual = _felicidadeMáxima;
        }
        if (_felicidadeAtual == 0)
        {
            _barrasFelicidade[0].SetActive(false);
            _barrasFelicidade[1].SetActive(false);
            _barrasFelicidade[2].SetActive(false);
            _barrasFelicidade[3].SetActive(false);
            _barrasFelicidade[4].SetActive(false);
        }
        if (_felicidadeAtual == 1)
        {
            _barrasFelicidade[0].SetActive(true);
            _barrasFelicidade[1].SetActive(false);
            _barrasFelicidade[2].SetActive(false);
            _barrasFelicidade[3].SetActive(false);
            _barrasFelicidade[4].SetActive(false);
        }
        if (_felicidadeAtual == 2)
        {
            _barrasFelicidade[0].SetActive(false);
            _barrasFelicidade[1].SetActive(true);
            _barrasFelicidade[2].SetActive(false);
            _barrasFelicidade[3].SetActive(false);
            _barrasFelicidade[4].SetActive(false);
        }
        if (_felicidadeAtual == 3)
        {
            _barrasFelicidade[0].SetActive(false);
            _barrasFelicidade[1].SetActive(false);
            _barrasFelicidade[2].SetActive(true);
            _barrasFelicidade[3].SetActive(false);
            _barrasFelicidade[4].SetActive(false);
        }
        if (_felicidadeAtual == 4)
        {
            _barrasFelicidade[0].SetActive(false);
            _barrasFelicidade[1].SetActive(false);
            _barrasFelicidade[2].SetActive(false);
            _barrasFelicidade[3].SetActive(true);
            _barrasFelicidade[4].SetActive(false);
        }
        if (_felicidadeAtual == 5)
        {
            _barrasFelicidade[0].SetActive(false);
            _barrasFelicidade[1].SetActive(false);
            _barrasFelicidade[2].SetActive(false);
            _barrasFelicidade[3].SetActive(false);
            _barrasFelicidade[4].SetActive(true);
        }
    }
}
