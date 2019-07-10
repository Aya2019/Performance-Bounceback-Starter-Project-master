using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    
    public GameManager gameManager;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
       // Text text = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Text text = GetComponentInChildren<Text>();
        text.text = "Score: " + gameManager.score.ToString();

	}
}
