using UnityEngine;
using System.Collections;

public class ScorpionController : MonoBehaviour {

    private enum STATE { WANDER, CHASE, ATTACK, DIE };

    private STATE currentState;
    
    public Animator myAnim;

    private Rigidbody2D myRB;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void EnterStateWander() {
        currentState = STATE.WANDER;
    }

    private void UpdateWander() {

    }

    private void EnterStateChase() {
        currentState = STATE.CHASE;
    }

    private void UpdateChase() {

    }

    private void EnterStateAttack() {
        currentState = STATE.ATTACK;
    }

    private void UpdateAttack() {

    }

    public void DoAttack() {

    }

    public void AttackOver() {

    }

    public void Die() {
        EnterStateDie();
    }

    private void EnterStateDie() {
        currentState = STATE.DIE;
        myAnim.SetTrigger("die");
        myRB.velocity = Vector2.zero;
        GetComponent<Collider2D>().enabled = false;
    }

    private void UpdateDie() {

    }
}
