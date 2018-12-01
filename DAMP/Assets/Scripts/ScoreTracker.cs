﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour {

    int score = 0;
    TextMeshProUGUI scoreText;


	// Use this for initialization
	void Start () {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + score;
	}
	
    void Increment() {
        score++;
        scoreText.text = "Score: " + score;
    }
}
