using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialControl : MonoBehaviour {
	
	public Text text;
	public bool CheckWASD = false;
	public bool CheckJump = false;
	public bool CheckDraw = false;
	public bool CheckShot = false;
	public Transform player;
	
	// Use this for initialization
	void Start () {
		text.resizeTextForBestFit = true;
		text.text = "Hello and welcome to the tutorial, hit WASD to move";
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.W) && CheckWASD == false  && CheckJump == false && CheckDraw == false && CheckShot == false){
			CheckWASD = true;
			text.text = "You can also jump by hitting the space bar";
		}
		if(Input.GetKey(KeyCode.Space) && CheckJump == false && CheckDraw == false && CheckShot == false){
			CheckJump = true;
			text.text = "You can draw your bow by hitting right click";
		}
		if(Input.GetMouseButton(1) && CheckDraw == false && CheckShot == false){
			CheckDraw = true;
			text.text = "You can fire an arrow while drawn by hitting left click";
		}
		if(Input.GetMouseButton(1) && Input.GetMouseButton(0) && CheckShot == false){
			CheckShot = true;
			text.text = "Nice, try shooting the target, when you are done, jump down to exit!";
			CheckShot = true;
		}
		if(player.position.y < -10){
			SceneManager.LoadScene("LevelSelection");
		}
		
		
	}
}
