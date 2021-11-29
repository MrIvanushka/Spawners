using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _enemyTemplate;

    public void SummonEnemy()
    {
        Instantiate(_enemyTemplate, _spawnPoint.position, Quaternion.identity);
    }
}
