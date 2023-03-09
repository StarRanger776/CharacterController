using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasHazard : MonoBehaviour
{
    public GameObject Player;
    public Health health;

    [SerializeField] private int damage;
    [SerializeField] private bool within;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            within = true;
            StartCoroutine(DamagePlayer(damage));
        }
    }

    IEnumerator DamagePlayer(int damage)
    {
        health.health -= damage;
        yield return new WaitForSeconds(1);
        if(within == true)
        {
            StartCoroutine(DamagePlayer(damage));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            within = false;
            StopAllCoroutines();
        }
    }
}
