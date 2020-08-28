using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    public GameObject[] waves;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        SpawnWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnWave(){

        float CharaSpeed = Player.GetComponent<CharaBehavior>().vitesse;
        Instantiate(waves[Random.Range(0,waves.Length)], new Vector3(gameObject.transform.position.x + 25, gameObject.transform.position.y - 11,-5), Quaternion.identity);
    }
}
