using System.Collections;
using UnityEngine;

public class OilCanSpawner : MonoBehaviour
{
    public GameObject oilCanPrefab;
    public Transform[] spawnPoints;
    public float spawnInterval = 11f;
    
    void Start()
    {
        StartCoroutine(SpawnOilCanRepeatedly());
    }

    IEnumerator SpawnOilCanRepeatedly()
    {
        while (true)
        {
            SpawnOilCan();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnOilCan()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        Transform selectedSpawnPoint = spawnPoints[randomIndex];

        if (selectedSpawnPoint != null)
        {
            Instantiate(oilCanPrefab, selectedSpawnPoint.position, selectedSpawnPoint.rotation);
        }
    }
}