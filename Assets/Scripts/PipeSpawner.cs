using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 2f;

    private Coroutine spawnCoroutine;

    public void StartSpawn()
    {
        if (spawnCoroutine != null)
            StopCoroutine(spawnCoroutine);

        spawnCoroutine = StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            float y = Random.Range(-heightOffset, heightOffset);
            Instantiate(pipePrefab, new Vector3(10f, y, 0), Quaternion.identity);

            yield return new WaitForSeconds(spawnRate);
        }
    }
}
