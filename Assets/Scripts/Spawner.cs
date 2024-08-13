using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public float spawnRate = 1f;
    public float spawnHeight = 6f;
    public float minX = -8f;
    public float maxX = 8f;

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            float spawnX = Random.Range(minX, maxX);
            GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

            // Instancia o objeto na posição aleatória no topo da tela
            Instantiate(objectToSpawn, new Vector3(spawnX, spawnHeight, 0), Quaternion.identity);

            // Espera antes de spawnar o próximo objeto
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
