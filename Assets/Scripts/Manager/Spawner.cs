using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Object fire;
    public Object rock;
    public float fireSpawnTime = 8f;
    public float rockSpawnTime = 1f;

    public int difficultyLevel = 1;
    int DifficultyLevel
    {
        get { return difficultyLevel; }
        set
        {
            if (value != difficultyLevel)
            {
                difficultyLevel = value;
                ChangeDifficulty();
            }
            else difficultyLevel = value;
        }
    }
    Vector3 spawnPosition = new Vector3(0, 6, 0);
    float rockTimer = 0;
    float fireTimer = 0.5f;
    private float diffTimer = 10;


    void Start()
    {

    }

    void Update()
    {
        rockTimer += Time.deltaTime;
        if (rockTimer > rockSpawnTime)
        {
            rockTimer = 0;
            StartCoroutine(SpawnRock());
        }
        
        fireTimer += Time.deltaTime;
        if (fireTimer > fireSpawnTime)
        {
            fireTimer = 0;
            StartCoroutine(SpawnFire());
        }

        diffTimer -= Time.deltaTime;
        if (diffTimer < 0)
        {
            diffTimer = 10;
            DifficultyLevel += 1;
        }
    }

    void ChangeDifficulty()
    {
        switch (DifficultyLevel)
        {
            case 1:
                rockSpawnTime = 1f;
                break;
            case 2:
                rockSpawnTime = 1f;
                break;
            case 3:
                rockSpawnTime = 0.9f;
                break;
            case 4:
                rockSpawnTime = 0.9f;
                break;
            case 5:
                rockSpawnTime = 0.8f;
                break;
            case 6:
                rockSpawnTime = 0.8f;
                break;
            default:
                break;

        }
    }

    IEnumerator SpawnFire()
    {
        Instantiate(fire, getRandomSpawnPosition(), new Quaternion(0, 0, 0, 0));

        yield return null;
    }

    IEnumerator SpawnRock()
    {
        Instantiate(rock, getRandomSpawnPosition(), new Quaternion(0, 0, 0, 0));
        int i = 4;
        if (DifficultyLevel - i >= 0)
            Instantiate(rock, getRandomSpawnPosition(), new Quaternion(0, 0, 0, 0));

        yield return null;
    }

    Vector3 getRandomSpawnPosition()
    {
        return new Vector3(Random.Range(-2.4f, 2.4f), 6.5f + Random.Range(-1f, 2f), 0);
    }

    void SetDifficulty()
    {

    }
}
