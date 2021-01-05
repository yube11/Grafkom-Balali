using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour{

	public Text scoreText;
	public Text hiScoreText;

	public float scoreCount;
	public float hiScoreCount;

	public float pointPerSecond;

	public bool scoreIncreasing;

	void Start(){
		// Membaca skor tertinggi
		if((int)PlayerPrefs.GetFloat("HighScore") != 0){
		 	hiScoreCount = PlayerPrefs.GetFloat("HighScore");
		}
		scoreIncreasing = true;
	}

	void Update(){

		if(scoreIncreasing){	
			scoreCount += pointPerSecond * Time.deltaTime;
            PlayerPrefs.SetFloat("Score", scoreCount);
		}

		// Mencetak skor tertinggi baru
		if(scoreCount > PlayerPrefs.GetFloat("HighScore")){
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat("HighScore", scoreCount);
		}

		// Mencetak skor dan skor tertinggi di layar permainan
		scoreText.text = "Skor: " + Math.Round(scoreCount);
		hiScoreText.text = "Skor Tertinggi: " + Math.Round(hiScoreCount);
	}

}