﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadWave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
    if(col.gameObject.CompareTag("WavePoint")){
        GameObject.Find("StartWavePoint").GetComponent<WaveSpawn>().SpawnWave();
    }
    }
}
