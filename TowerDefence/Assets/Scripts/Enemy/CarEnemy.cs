using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnemy : Enemy {
	[SerializeField] Vector3 moveVec = Vector3.zero;
	Rigidbody rigid = null;
	void Start(){
		rigid = GetComponent<Rigidbody> ();
	}

	protected override void Move(){
		rigid.transform.position += speed * moveVec.normalized;
	}
}
