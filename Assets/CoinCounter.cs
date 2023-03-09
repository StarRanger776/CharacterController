using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public int count;

    public int winCount = 10;

    public GameObject win;
    public GameObject lose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Coins: " + count.ToString();

        if(count >= winCount && lose.activeInHierarchy == false)
        {
            win.SetActive(true);
            Debug.Log("You Won");
        }
    }
}
