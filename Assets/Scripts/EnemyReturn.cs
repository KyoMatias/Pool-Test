using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReturn : MonoBehaviour
{
    private ObjectPoolEnemy _objectPool;
    
    // Start is called before the first frame update
    void Start()
    {
        _objectPool = FindObjectOfType<ObjectPoolEnemy>();
    }

    private void OnDisable()
    {
        if (_objectPool != null)
        {
            _objectPool.ReturnEnemy(this.gameObject);
        }
    }
}
