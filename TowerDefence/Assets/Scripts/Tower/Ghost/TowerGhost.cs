using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerGhost : MonoBehaviour {
	protected TowerManager.TowerType type;

	protected void Move(){
		Camera mainCamera = Camera.main;
		Ray ray = mainCamera.ScreenPointToRay ();

//		if (Physics.Raycast (ray)) {
//			Debug.DrawRay()
//		}
	}

	protected void CanSet(){

	}

	protected void Set(){

	}

	void Update(){

	}
}
