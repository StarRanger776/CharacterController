using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPickup : MonoBehaviour
{
    [SerializeField] GameObject nextHealth;
    [SerializeField] GameObject Player;
    [SerializeField] Health Health;
    [SerializeField] private int heal;


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
        if (other.gameObject == Player && Health.health <= 100 - heal)
        {
            Health.health += heal;
            nextHealth.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
