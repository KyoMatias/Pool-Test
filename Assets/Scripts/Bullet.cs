using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Life = 3;
    private Enemy _enemy;

    //public float ProjectileSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        _enemy = FindObjectOfType<Enemy>();
    }

    private void Awake()
    {
        Destroy(gameObject, Life);
    }
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            _enemy.TakeDmg(1);
        }
        Destroy(gameObject);
    }


    //

    // Update is called once per frame
    void Update()
    {
        
    }
}
