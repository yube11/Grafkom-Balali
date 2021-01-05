using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	
	private ScoreManager theScoreManager;

	void Start () {
		// Skor
		theScoreManager = FindObjectOfType<ScoreManager>();
	}

	void Update () {

	}

}