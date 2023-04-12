using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinissLine : MonoBehaviour
{

    [SerializeField] private Text totalEarned;
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== "El") 
        {       
            totalEarned.text = ("Money Earned:     "+((gameManager.moneyCount - 1) * 3).ToString());
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
