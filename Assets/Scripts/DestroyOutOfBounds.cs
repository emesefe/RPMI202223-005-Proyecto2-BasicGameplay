using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLimit = 30f;
    private float lowerLimit = -10f;

    private void Update()
    {
        // LÍMITE INFERIOR -> ANIMALES NO ALIMENTADO
        if (transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
            
            // Mecánica del Game Over
            Debug.Log("GAME OVER");
            Time.timeScale = 0; // Paramos el tiempo
        }

        // LÍMITE SUPERIOR -> BALA FALLIDA
        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
