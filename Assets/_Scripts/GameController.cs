using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public PlayerController player; 
	public Text Score;
	public Text GameOver; 
	public Text RestartText;
	public Text LevelComplete;
	public Text SummaryText;

	private int count; 
	private const int scoreIncr = 10, bonusIncr = 50;
	private bool isGameOver; 
	private bool restart;
	private float time;

	// Use this for initialization
	void Start () {
		isGameOver = false; 
		count = 0; 
		printScore ();
		GameOver.text = ""; 
		RestartText.text = "";
		LevelComplete.text = "";
		SummaryText.text = "";
		restart = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		// NEED TO POLL FOR THE RESTART;
		{
			if (restart)
			{

				RestartText.text = "Press R to restart level. "; 
				SummaryText.text = "Score : " + count.ToString ();

				if (Input.GetKeyDown (KeyCode.R))
				{
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
				}
			}
		}
	}

	void printScore(){
		Score.text = "Score: " + count.ToString ();
	}
	public void addScore(string type){
		if (type == "normal"){
			count = count + scoreIncr;
			Debug.Log ("Normal cube");
			printScore ();
		}
		else if (type == "bonus"){
			count = count + bonusIncr;
			Debug.Log ("Bonus cube");
			printScore();
		}
	}

	public void setGameOver(){
		isGameOver = true;
		GameOver.text = "GAME OVER."; 
		restart = true;
	}

	public void setLevelComplete(){
		LevelComplete.text = "Level Complete!";
		restart = true;
	}
		
}
