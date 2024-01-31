using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour // ESSE SCRIPT FICA NOS TRIGGERS
{
    CarSpawn sc_carSpawn;
    void Start()
    {
        sc_carSpawn = Camera.main.GetComponent<CarSpawn>();
    }

    void Update()
    {
        
    }
        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 13)
        {
            Debug.Log("ue");
            sc_carSpawn.SpawnarCarro();
        }
    }
}
