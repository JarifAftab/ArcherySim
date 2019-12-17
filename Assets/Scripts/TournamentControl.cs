using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TournamentControl : MonoBehaviour {
	
	public Text roundText;
	public static int roundNum = 1;
	public static int highScore;
	public Rigidbody player;
	
	// Use this for initialization
	void Start () {
		print(PlayerPrefs.GetInt("HighScore"));
		roundText.text = "Round " + roundNum;
		if(PlayerPrefs.HasKey("HighScore") == false){
			PlayerPrefs.SetInt("HighScore", 0);
		}
		highScore = PlayerPrefs.GetInt("HighScore");
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(1) && ArrowController.arrowLoaded == true){
			roundText.text = "";
		}
		if(ArrowController.arrowCount == 0){
			roundNum++;
			roundText.text = "Round "+roundNum;
			ArrowController.arrowCount = 3;
		}
		if(roundNum > 10){
			
			
			if(TargetDetectionMain.score > PlayerPrefs.GetInt("HighScore")){
				highScore = TargetDetectionMain.score;
				PlayerPrefs.SetInt("HighScore", highScore);
			}
			
			TargetDetectionMain.score = 0;
			SceneManager.LoadScene("titleScreen");
			roundNum = 1;
			
		}
		
		if(player.transform.position.x <= -2.2 || player.transform.position.x>2.9 ){
			player.transform.position = new Vector3(0.57f,1,-24);
		}
		if(player.transform.position.z <= -27.72){
			player.transform.position = new Vector3(0.57f,1,-24);
		}
		if(player.transform.position.z >= -5){
			player.transform.position = new Vector3(0.57f,1,-24);
		}
		
			
		
		
		
		
	}
}
