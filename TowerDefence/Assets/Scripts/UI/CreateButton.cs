using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateButton : MonoBehaviour {
	[SerializeField]UIController controller;
	void Awake(){
		GetComponent<Button> ().onClick.AddListener (controller.CreateToSetTower);
	}

}
