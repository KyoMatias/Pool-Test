using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    
    public static event Action<Enemy> OnEnemyKilled;
    [SerializeField] private float _health, _maxHealth = 3f;

    // Start is called before the first frame update
    private void Start()
    {
        _health = _maxHealth;
    }


    public void TakeDmg(float DamageTaken)
    {
        _health -= DamageTaken;

        if (_health <= 0)
        {
            Destroy(gameObject);
            OnEnemyKilled?.Invoke(this);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
    //new
}
