﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	void LoadNextLevel(){
		Debug.Log ("Loading Next Level");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}