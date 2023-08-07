using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            ControladorJuego.Instance.UltimoPuntoControl(gameObject);
        }
    }
}
