using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemyPrefab);
        enemy.Init(GetRandomDirection(), transform.position);
    }

    private Vector3 GetRandomDirection()
    {
        Vector3[] directions = new Vector3[]
        {
            Vector3.forward,
            Vector3.back,
            Vector3.left,
            Vector3.right
        };

        return directions[Random.Range(0, directions.Length)];
    }
}
