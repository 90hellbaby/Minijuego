using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugabilidad : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 PosicionInicial;

    private void Awake() {
        GestorEventos.EventoMuerteJugador += proximoIntento;
    }

    private void OnDestroy() {
        GestorEventos.EventoMuerteJugador -= proximoIntento;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void proximoIntento()
    {
        rb.velocity = Vector2.zero;
        transform.position = PosicionInicial;
    }
}
