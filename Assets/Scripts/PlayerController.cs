using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f; // Velocidad del player
    private float xRange = 15f; // Límites horizontales del movimiento del player

    public GameObject projectilePrefab; // Referencia al prefab del proyectil
    
    private float horizontalInput;

    private void Update()
    {
        // Movimiento horizontal del player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed *
                            Time.deltaTime * horizontalInput);
        
        PlayerInBounds(); // Mantiene al player en la pantalla

        // Mecánica del disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }
    
    // Función que se encarga de hacer aparecer al proyectil
    private void FireProjectile()
    {
        Instantiate(projectilePrefab,
            transform.position, Quaternion.identity);
    }

    // Función que mantiene al player dentro de los límites horizontales de la pantalla
    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;
        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }

        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
    }
}
