using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

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
}
