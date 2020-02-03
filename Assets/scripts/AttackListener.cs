using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackListener : MonoBehaviour {

    public ScorpionController controller;

	// Use this for initialization
	public void AttackTrigger () {
        controller.DoAttack();
	}
	
	// Update is called once per frame
	public void AttackOver () {
        controller.AttackOver();
	}
}
