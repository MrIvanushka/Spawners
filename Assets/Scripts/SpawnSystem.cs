using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    [SerializeField] private float _spawnDelayTime;

    private Coroutine _spawnCoroutine;
    private WaitForSeconds _spawnDelay;

    private void Awake()
    {
        _spawnDelay = new WaitForSeconds(_spawnDelayTime);
    }

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

        while(true)
        {
            _spawners[currentSpawnerIndex].SummonEnemy();
            currentSpawnerIndex = Mathf.RoundToInt(Mathf.Repeat(currentSpawnerIndex + 1, _spawners.Length));
            yield return _spawnDelay;
        }
    }

    
}
