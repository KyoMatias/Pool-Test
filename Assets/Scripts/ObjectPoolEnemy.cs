using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Queue<GameObject> _enemyPool = new Queue<GameObject>();
    [SerializeField] private int _poolInitSize = 5;

    private void Start()
    {
        for (int i = 0; i < _poolInitSize; i++)
        {
            GameObject Enemy = Instantiate(_enemyPrefab);
            _enemyPool.Enqueue(Enemy);
            Enemy.SetActive(false);
        }
    }

    public GameObject GetEnemy()// Spawn system/logic
    {
        if (_enemyPool.Count > 0)//Checks if pool count is more than zero. hence, there are enemies on the map.
        {
            GameObject Enemy = _enemyPool.Dequeue();//dequeues the pool
            Enemy.SetActive(true);//spawns an instantiated enemy prefab
            return Enemy;//returns the property of enemy prefab
        }
        else //if the enemy pool count IS zero, then it instantiates an enemy on the map/ Spawn System
        {
            GameObject Enemy = Instantiate(_enemyPrefab);// Spawns the enemy
            return Enemy;// returns properties of the enemy prefab.
        }
    }

    public void ReturnEnemy(GameObject Enemy)
    {
        _enemyPool.Enqueue(Enemy);
        Enemy.SetActive(false);
    }
}
