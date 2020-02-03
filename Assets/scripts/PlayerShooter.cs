using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour


{
    public GameObject bullet;
    public float bulletSpeed;
    public float fireTime;
    public Animator animator;

    private Vector2 _lastVel = Vector2.up;
    private float _timeToFire;
    private Rigidbody2D _myRigidbody2D;

    void Start()
    {
        _myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _timeToFire -= Time.deltaTime;
        if (-_myRigidbody2D.velocity.magnitude > 0f) _lastVel = _myRigidbody2D.velocity.normalized;
        if(Input.GetKey(KeyCode.Space) && _timeToFire <= 0f)
        {
            animator.SetTrigger("cast");
            _timeToFire = fireTime;
        }
    }

    public void FireBullet()
    {
        GameObject gO = Instantiate(bullet, transform.position, Quaternion.Euler(_lastVel)) as GameObject;
        gO.GetComponent<Rigidbody2D>().velocity = _lastVel * bulletSpeed;
        gO.transform.localEulerAngles = animator.transform.localEulerAngles;
    }

}
