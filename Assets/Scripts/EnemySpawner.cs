using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Point[] _points;
    private void Start()
    {
        _points = GetComponentsInChildren<Point>();
        
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        foreach (var point in _points)
        {
            Instantiate(_enemy, point.transform);
            yield return new WaitForSeconds(2f);
        }
    }
}
