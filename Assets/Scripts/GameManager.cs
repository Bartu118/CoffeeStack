using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int moneyCount = 0;
    private TextMesh moneyText;
    private void Awake()
    {
        moneyText=GameObject.Find("moneyText").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        moneyCount = GameObject.FindGameObjectsWithTag("Player").Length + GameObject.FindGameObjectsWithTag("ilkGelistirme").Length + GameObject.FindGameObjectsWithTag("ikinciGelistirme").Length + GameObject.FindGameObjectsWithTag("Pipet").Length;
        moneyText.text = (moneyCount-1).ToString();
        
    }
}
