using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	public Text highScoreText;
    public Text zombieHighScoreText;

	public void startMenu(){
		
		SceneManager.LoadScene("LevelSelection");
		
	}
	public void startTutorial(){
		
		SceneManager.LoadScene("ShootingRange");
		
	}
	public void startMain(){
		SceneManager.LoadScene("MainLevel");
	}

    public void zombie(){
        SceneManager.LoadScene("zombieLevel");
    }
	
	void Update(){
		highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        zombieHighScoreText.text = "Zombie High Score: " + PlayerPrefs.GetInt("ZombieHighScore");
	}
}
	

