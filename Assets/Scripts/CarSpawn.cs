using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour // ESSE SCRIPT FICA NA CAMERA
{
    [SerializeField] GameObject _carro;
    [SerializeField] float _time = 0, _maxTime = 1;
    [SerializeField] public Transform _carSpawner1, _carSpawner2;

    [SerializeField] MoveCar _moveCarFab;
    void Start()
    {
        _moveCarFab = _carro.GetComponent<MoveCar>();
    }

    void Update()
    {
        _time += Time.deltaTime;
    }
    public void SpawnarCarro()
    {
        Debug.Log("ChamouAteAqui");
        if (_time > _maxTime)
        {
            GameObject novoCarro = Instantiate(_carro);
            if (_moveCarFab._vaiDireita)
            {
                _moveCarFab._vaiDireita = true;
                novoCarro.transform.position = _carSpawner1.position;
            }
            if (_moveCarFab._vaiEsquerda)
            {
                _moveCarFab._vaiEsquerda = true;
                novoCarro.transform.position = _carSpawner2.position;
            }
            Destroy(novoCarro,5f);
            _time = 0;
        }
    }
    /*private void CarSpawn1()
    {
        Instantiate(_carro);
    }*/
}
