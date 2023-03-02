using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] GameObject nextCoin;
    [SerializeField] GameObject Player;
    [SerializeField] CoinCounter Count;
    

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
            Count.count += 1;
            nextCoin.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
