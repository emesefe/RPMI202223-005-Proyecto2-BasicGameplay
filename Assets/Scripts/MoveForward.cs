using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 40f;

    private void Update()
    {
        // Mover hacia adelante a la velocidad speed
        transform.Translate(Vector3.forward * 
                            speed * Time.deltaTime);
    }
}
