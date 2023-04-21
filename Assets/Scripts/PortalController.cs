using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{

    public GameObject enemigoPrefab;
    public Transform puntoPartida;
    public float tiempoPartida = 3f;


    void Start()
    {
        InvokeRepeating("GenerarEnemigo", tiempoPartida, tiempoPartida);

    }


    void GenerarEnemigo()
    {
        Instantiate(enemigoPrefab, puntoPartida.position, Quaternion.identity);
    }
}