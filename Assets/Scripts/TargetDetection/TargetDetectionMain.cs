using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetDetectionMain : MonoBehaviour {
	
	public static int score;
	public Text text;
	public static bool hit = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Points " + score;
		
		
	}
}
