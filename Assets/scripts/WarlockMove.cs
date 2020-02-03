using UnityEngine;
using System.Collections;
using System.Collections.Generic;
// Need to add access to System.Collections.Generic in order to use a dictionary

public class WarlockMove : MonoBehaviour {

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    private Dictionary<Vector2, float> angleByVelocity = new Dictionary<Vector2, float>()
    {
        { (new Vector2(0f, 1f)).normalized, 0f },
        { (new Vector2(-1f, 1f)).normalized, 45f },
        { (new Vector2(-1f, 0f)).normalized, 90f },
        { (new Vector2(-1f, -1f)).normalized, 135f },
        { (new Vector2(0f, -1f)).normalized, 180f },
        { (new Vector2(1f, -1f)).normalized, 225f },
        { (new Vector2(1f, 0f)).normalized, 270f },
        { (new Vector2(1f, 1f)).normalized, 315f }
    };
}
