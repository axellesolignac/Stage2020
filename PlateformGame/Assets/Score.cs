using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
	public int baseScorePoint = 1;
	public int multiplier = 1;
	private int currentScore = 0;

	// Use this for initialization
	void Start () {
		currentScore = 0;
		StartCoroutine("Scoring");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateScore (int scoreToAdd){
		currentScore += scoreToAdd*multiplier;
		gameObject.GetComponent<Text>().text = currentScore + "";
	}

	private IEnumerator Scoring(){

		while(true){
			UpdateScore(baseScorePoint);
			yield return new WaitForSeconds(0.1f);
		}
	}
}
