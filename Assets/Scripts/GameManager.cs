using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float restartDelay = 1f;
	public GameObject levelCompleteUI;

	public void CompleteLevel(){
		Debug.Log ("Level Won!");
		levelCompleteUI.SetActive(true);
	}

	public void EndGame (){

		if (gameHasEnded == false) {
			Debug.Log ("Game Over");
			gameHasEnded = true;

			Invoke("Restart", restartDelay);
		}

	}

	void Restart(){

		SceneManager.LoadScene (SceneManager.GetActiveScene().name);

	}

}


