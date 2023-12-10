using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // El prefab del enemigo que deseas spawnear
    public float spawnInterval = 5.0f; // Intervalo de tiempo entre spawns
    public Transform spawnPoint; // El punto de spawn de los enemigos

    void Start()
    {
        // Comienza a spawnear enemigos inmediatamente
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            // Crea una instancia del enemigo en el punto de spawn
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

            // Espera el intervalo de tiempo antes del próximo spawn
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
