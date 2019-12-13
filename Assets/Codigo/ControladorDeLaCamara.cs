using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeLaCamara : MonoBehaviour {

    public GameObject jugador;
    private Vector3 posicionRelativa;

    void Start() {
        posicionRelativa = transform.position - jugador.transform.position;
    }

    void Update() {
        transform.position = jugador.transform.position + posicionRelativa;
    }
}
