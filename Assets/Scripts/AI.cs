using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AI : MonoBehaviour
{
    public Transform Player;
    public float ChaseSpeed = 5f;
    private Rigidbody _rb;
    private Vector3 _movement;

    private void Start()
    {
        Player = FindObjectOfType<RotateAround>().GetComponent<Transform>();
        
    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, Player.position) > 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.position, ChaseSpeed * Time.fixedDeltaTime);

            Vector3 AIPath = Player.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(AIPath);
            transform.rotation = rotation;
        }
    }
}

