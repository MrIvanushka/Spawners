using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    [SerializeField] private float _spawnDelay;

    private Coroutine _spawnCoroutine;

    private void OnEnable()
    {
        _spawnCoroutine = StartCoroutine(Spawn());
    }
    
    private void OnDisable()
    {
        StopCoroutine(_spawnCoroutine);
    }

    private IEnumerator Spawn()
    {
        int currentSpawnerIndex = 0;

        for (; ; )
        {
            _spawners[currentSpawnerIndex].SummonEnemy();
            currentSpawnerIndex = Mathf.RoundToInt(Mathf.Repeat(currentSpawnerIndex + 1, _spawners.Length));
            yield return new WaitForSeconds(_spawnDelay);
        }
    }

    
}
