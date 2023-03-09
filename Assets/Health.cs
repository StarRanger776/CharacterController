using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health = 100;

    public GameObject win;
    public GameObject lose;
    public TMPro.TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Health: " + health.ToString();

        if (health <= 0 && win.activeInHierarchy == false)
        {
            lose.SetActive(true);
            Debug.Log("You Lost");
        }
    }
}
