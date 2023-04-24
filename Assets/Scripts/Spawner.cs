using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _timeToSpawn = 5f;
    private float _timeSinceSpawn;
    private ObjectPoolEnemy _objectPool;
    
    // Start is called before the first frame update
    void Start()
    {
        _objectPool = FindObjectOfType<ObjectPoolEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        _timeSinceSpawn += Time.deltaTime;
        if(_timeSinceSpawn >= _timeToSpawn)
        {
            GameObject newEnemy = _objectPool.GetEnemy();
            newEnemy.transform.position = this.transform.position;
            _timeSinceSpawn = 0f;
        }
    }
}
