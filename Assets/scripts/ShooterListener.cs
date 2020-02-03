using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterListener : MonoBehaviour
{
    public PlayerShooter myShooter;
    public void FireReady()
    {
        myShooter.FireBullet();
    }
  
}
