using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaftormSpawner : MonoBehaviour
{
    public GameObject[] platforms;
    public Transform charPos;
    public Transform charPoint;
    Vector3 spawnPoint;
    bool canSpawn;
    int random;
    void Start()
    {
        SpawnPlatform();
    }

    void Update()
    {
        canSpawn = GameManager.INS.spawnPlat;
        if (spawnPoint.y < charPoint.position.y && canSpawn)
        {
            SpawnPlatform();
        }
    }

    void SpawnPlatform()
    {
        random = Random.Range(0, platforms.Length);
        spawnPoint.Set(charPoint.position.x + 1.5f, charPoint.position.y + 1,0);
        GameObject clonDer = Instantiate(platforms[random],spawnPoint,Quaternion.identity);
        //Debug.Log("Primer valor: "+random);
        if (random == 0)
        {
            random = Random.Range(1, platforms.Length);
        }
        else
        {
            random = Random.Range(0, platforms.Length);
        }
        //Debug.Log("Segundo valor: " + random);
        spawnPoint.Set(charPoint.position.x - 1.5f, charPoint.position.y + 1, 0);
        GameObject clonIzq = Instantiate(platforms[random], spawnPoint, Quaternion.identity);
    }
}
