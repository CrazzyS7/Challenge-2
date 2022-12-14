 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] mBallPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float mStartDelay = 1.0f;
    private int mMinSpawnInterval = 3;
    private int mMaxSpawnInterval = 6;

    // Start is called before the first frame update
    void Start()
    {
        float spawnInterval = Random.Range(mMinSpawnInterval, mMaxSpawnInterval);
        InvokeRepeating("SpawnRandomBall", mStartDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int index = Random.Range(0, mBallPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(mBallPrefabs[index], spawnPos, mBallPrefabs[index].transform.rotation);
    }

}
