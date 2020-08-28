using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvaManager : MonoBehaviour
{
    public GameObject btnpause;
    public GameObject panelpause;
    public GameObject panelgameover;
    public GameObject panelcointxt;
    public GameObject gameovercointxt;

    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PausePlay(){
        if(isPause){
            isPause = false;
            Time.timeScale = 1;
            btnpause.SetActive(true);
            panelpause.SetActive(false);
        }
        else{
            isPause = true;
            Time.timeScale = 0;
            btnpause.SetActive(false);
            panelpause.SetActive(true);
        }
    }

    public void Again(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Jeu");
    }

    public void GameOver(){
        Time.timeScale = 0;
        panelgameover.SetActive(true);
        btnpause.SetActive(false);
        panelcointxt.GetComponent<CoinAmount>().SaveCoin();
        gameovercointxt.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinAmount") + "";
    }
}
