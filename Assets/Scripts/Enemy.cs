using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }

    public void Init(Vector3 direction, Vector3 position)
    {
        transform.position = position;
        transform.rotation = Quaternion.LookRotation(direction);
        _direction = direction;
    }
}
