using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnerPoint[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        float delay = 2f;
        WaitForSeconds wait = new(delay);

        while (true)
        {
            _spawnPoints[Random.Range(0, _spawnPoints.Length)].Spawn();
            yield return wait;
        }
    }
}
