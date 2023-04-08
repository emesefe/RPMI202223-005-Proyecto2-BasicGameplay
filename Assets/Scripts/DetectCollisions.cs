using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Destruye el proyectil (porque es el proyectil quien tiene este script como componente)
        Destroy(other.gameObject); // Destruye el animal con el que colisiono
    }
}
