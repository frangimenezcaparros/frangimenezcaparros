using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{
    //Almacena componente Rigidbody del personaje Jugador.
    Rigidbody rb;
    public float velocidad;
    public int contador;
    public Text marcador;
    public Text findejuego;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        ActualizarMarcador();
        findejuego.gameObject.SetActive(false);
    }
    public void fixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        ActualizarMarcador();
        if (contador >= 5)
        {
            findejuego.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void ActualizarMarcador()
    {
        marcador.text = "Puntos: " + contador;
    }
}     