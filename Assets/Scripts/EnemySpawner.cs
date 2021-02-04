using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Point[] _points;

    private void Awake()
    {
        _points = GetComponentsInChildren<Point>();
    }

    private void Start()
    {
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
