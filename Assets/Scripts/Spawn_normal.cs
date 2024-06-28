using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_normal : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform [] SpawnPosition; // Luego hacer versión array
    private GameObject newObject;

    public float spawnInterval = 3f;
    public float objectLifetime = 2f;
    private float timer = 0f;
    private int random;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            random = Random.Range(0, SpawnPosition.Length);
            // Debug.Log("Appear");
            // Instantiate(objectToSpawn, SpawnPosition.position, Quaternion.identity);
            newObject = Instantiate(objectToSpawn, SpawnPosition[random].position, Quaternion.identity);

            timer = 0f;

            if(newObject != null)
            {
                Debug.Log($"Destroy. Tag={newObject.tag}");
                Destroy(newObject, objectLifetime);
            }
        }
    }
}
