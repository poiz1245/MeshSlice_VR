using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject targetObject;
    [SerializeField] float spawnSpeed;
    [SerializeField] float spawnTime;
    void Start()
    {
        spawnTime = spawnSpeed;
    }

    void Update()
    {
        spawnTime -= Time.deltaTime;

        if(spawnTime < 0)
        {
            Instantiate(targetObject, transform.position, Quaternion.identity);
            spawnTime = spawnSpeed;
        }
    }
}
