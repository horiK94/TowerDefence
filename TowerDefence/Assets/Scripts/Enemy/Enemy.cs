using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {
	[SerializeField]protected float speed = 0;
	[SerializeField]protected int life = 1;
	[SerializeField]protected int obtainEnergy = 1;
	bool isStop = false;

	void Update(){
		if (isStop) {
			return;
		}
		Move ();
		if (IsDead ()) {
			Dead ();
		}
	}

	protected virtual void Move(){}

	protected void Dead(){
		// TODO
	}

	protected bool IsDead(){
		if (life <= 0) {
			return true;
		}
		return false;
	}

	public void ReduceLife(int damage){
		life -= damage;
	}

	protected void Stop(){
		isStop = true;
	}
}
