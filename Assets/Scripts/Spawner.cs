using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Enemy _template;

    public void SummonEnemy()
    {
        Instantiate(_template, _spawnPoint.position, Quaternion.identity);
    }
}
