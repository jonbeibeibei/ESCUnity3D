using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour {

	public Canvas MainCanvas; 
	public Canvas LeaderboardCanvas;

	public SceneManager scene;

	void Awake(){
		LeaderboardCanvas.enabled = false;

	}

	public void LeaderboardOn(){
		MainCanvas.enabled = false;
		LeaderboardCanvas.enabled = true;
	}

	public void returnFromLeaderboard(){
		LeaderboardCanvas.enabled = false;
		MainCanvas.enabled = true;
	}


	public void startSoloPlay(){
		SceneManager.LoadScene ("Main");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
