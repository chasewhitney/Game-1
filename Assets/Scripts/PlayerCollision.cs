﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter(Collision collisionInfo) {
		if (collisionInfo.collider.tag == "Obstacle") {
		
			Debug.Log ("You hit an obstacle!");

			movement.enabled = false;
			//GetComponent<PlayerMovement> ().enabled = false; // same functionality as movement.enabled = false

			FindObjectOfType<GameManager> ().EndGame();
		}

	}

}
