using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour // ESSE SCRIPT FICA NO PREFAB DO CARRO
{
    public bool _vaiEsquerda, _vaiDireita;
    [SerializeField] float _speed;

    CarSpawn sc_carSpawn;
    void Start()
    {
        sc_carSpawn = Camera.main.GetComponent<CarSpawn>();
    }

    
    void Update()
    {
        int random = Random.Range(0,1);
        if(random == 0)
        {
            _vaiEsquerda = true;
        }
        else
        {
            _vaiDireita = true;
        }
        if (_vaiDireita)
        {
            transform.localScale = new Vector3(-1,1,1);

            //Transform _carSpawnDireita = sc_carSpawn._carSpawner2;
            //transform.position = _carSpawnDireita.position;
            transform.position += Vector3.right * _speed * Time.deltaTime;
        }
        if (_vaiEsquerda)
        {
            //Transform _carSpawnDireita = sc_carSpawn._carSpawner1;
            //transform.position = _carSpawnDireita.position;
            transform.position += Vector3.left * _speed * Time.deltaTime;
        }
    }
}
