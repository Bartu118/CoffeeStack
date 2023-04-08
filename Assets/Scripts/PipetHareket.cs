using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PipetHareket : MonoBehaviour
{
    [SerializeField] private Transform patrol1;
    public GameObject hareket;
    //[SerializeField] private Transform patrol2;

    // Start is called before the first frame update
    void Start()
    {
        hareket.transform.DOMove(patrol1.position, 0.2f).SetLoops(1000,LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
            
        
    }
}
