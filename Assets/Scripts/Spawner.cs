using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    private Transform[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();

        StartCoroutine(Spawn());
    }

    private Quaternion GetRandomDirection()
    {
        float angle = Random.Range(0f, 360f);

        return Quaternion.Euler(0f, angle, 0f);
    }

    private IEnumerator Spawn()
    {
        float delay = 2f;
        WaitForSeconds wait = new (delay);

        while (true)
        {
            Vector3 spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;

            Enemy enemy = Instantiate(_enemyPrefab, spawnPoint, GetRandomDirection());

            yield return wait;
        }
    }
}
