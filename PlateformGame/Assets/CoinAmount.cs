using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text =  "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SaveCoin(){
        int CoinCollected = PlayerPrefs.GetInt("CoinAmount");
        PlayerPrefs.SetInt("CoinAmount", CoinCollected + int.Parse(gameObject.GetComponent<Text>().text));
    }
}
