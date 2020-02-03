using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermover : MonoBehaviour 
{
    public GameObject display;
    public Animator animator;
    public float moveSpeed;

    private Rigidbody2D _myRigidbody2D;
    void Start()
    {
        _myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 newVel = Vector2.zero;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            newVel += Vector2.up;
        }else if(Input.GetKey(KeyCode.DownArrow))
        {
            newVel -= Vector2.up;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            newVel += Vector2.right;
        }else if(Input.GetKey(KeyCode.LeftArrow))
        {
            newVel -= Vector2.right;
        }

        _myRigidbody2D.velocity = newVel.normalized * moveSpeed;
        animator.SetFloat("Speed", newVel.magnitude);
        Debug.Log(newVel.magnitude);
        if(newVel.magnitude > 0f)
        {
            display.transform.localEulerAngles = Vector3.forward * angleByVelocity[newVel.normalized];
        }
    }
    private Dictionary<Vector2, float> angleByVelocity = new Dictionary<Vector2, float>()
    {
        { (new Vector2(0f,1f)).normalized, 0f },
        { (new Vector2(-1f,1f)).normalized, 45f },
        { (new Vector2(-1f,0f)).normalized, 90f },
        { (new Vector2(-1f,-1f)).normalized, 135f },
        { (new Vector2(0f,-1f)).normalized, 180f },
        { (new Vector2(1f,-1f)).normalized, 225f },
        { (new Vector2(1f,0f)).normalized, 270f },
        { (new Vector2(1f,1f)).normalized, 315f },

    };
}
