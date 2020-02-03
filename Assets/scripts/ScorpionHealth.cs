using UnityEngine;
using System.Collections;

public class ScorpionHealth : MonoBehaviour {

    public int health = 1;
    public ScorpionController myController;
    

	// Use this for initialization
	void OnCollisionEnter2D (Collision2D collision) {
        Debug.Log(gameObject + "Collision with" + collision.collider.gameObject.name);
        if (collision.collider.gameObject.name.Contains("bullet"))
        {
            TakeDamage(1);
        }
	}
	
	// Update is called once per frame
	private void TakeDamage (int damageAmount) {
        health -= damageAmount;
        if (health <= 0)
        {
            myController.Die();
        }
	}
}
