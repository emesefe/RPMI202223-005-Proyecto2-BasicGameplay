using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Array de animales
    private int animalIndex; // Índice del array de animales
    
    private float spawnRangeX = 14f;
    private float spawnPosZ = 15f;

    private float startDelay = 1.5f;
    private float spawnInterval = 2f;

    private void Start()
    {
        // Llama periódicamente a la función SpawnRandomAnimal
        InvokeRepeating("SpawnRandomAnimal",
            startDelay, spawnInterval);
    }

    // Función que hace aparecer un animal aleatorio en una posición aleatoria
    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length); // Generamos índice aleatorio
        Instantiate(animalPrefabs[animalIndex],
            RandomSpawnPos(),
            animalPrefabs[animalIndex].transform.rotation);
    }
    
    // Función que genera un vector aleatorio
    private Vector3 RandomSpawnPos(){
        float randomX = Random.Range(-spawnRangeX, spawnRangeX); // Generamos número aleatorio para la coordenada x
        return new Vector3(randomX, 0, spawnPosZ);
    }
}
