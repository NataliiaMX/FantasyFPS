using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHP = 100;

    public void TakeDamage (float damagePoints)
    {
        playerHP -= damagePoints;
        Debug.Log(playerHP);

        if (playerHP <= 0)
        {
            Debug.Log("you're dead");
        }
    }
}