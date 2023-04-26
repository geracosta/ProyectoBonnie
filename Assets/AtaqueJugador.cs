using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueJugador : MonoBehaviour
{
    public Transform posicionProyectil;
    public GameObject proyectil;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            Instantiate(proyectil, posicionProyectil.position,posicionProyectil.rotation);
        }
    }
}
