using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZombieLevelController : MonoBehaviour {
	
	public Rigidbody player;
	
	public static int numSpawn = 1; //The inital number of zombies to spawn
	public Rigidbody zombie; //The zombie we will actually clone
	public static int kills = 0; //Tracks number of zombie kills
	public static int zombieCount = 1;
    public static bool dead = false;

	public void spawnZombies(){
		
		if(zombieCount <= 1){
			for(int i = 0; i < numSpawn; i++){
				Instantiate(zombie, new Vector3(Random.Range(-15f,15f), 1.06f, Random.Range(-16f,16f)), zombie.rotation);
				zombieCount++;
			}
			numSpawn++;
		}
	}
	
	public void regulatePlayer(){
		if(player.transform.position.x < -15.5f || player.transform.position.x>15.5f ){
			player.transform.position = new Vector3(0f,1f,0f);
		}
		if(player.transform.position.z < -16.5f){
			player.transform.position = new Vector3(0f,1f,0f);
		}
		if(player.transform.position.z > 16.5f){
			player.transform.position = new Vector3(0f,1f,0f);
		}
	}
	// Use this for initialization
	void Start () {
        zombie.velocity = new Vector3(0,0,0);
		if (PlayerPrefs.HasKey("ZombieHighScore") == false)
        {
            PlayerPrefs.SetInt("ZombieHighScore", 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
		ArrowController.arrowCount = 3;
		regulatePlayer();
		spawnZombies();

        if (dead == true){
            if (kills>PlayerPrefs.GetInt("ZombieHighScore")){
                PlayerPrefs.SetInt("ZombieHighScore", kills);
            }
			dead = false;
            SceneManager.LoadScene("titleScreen");
        }
	}
}
