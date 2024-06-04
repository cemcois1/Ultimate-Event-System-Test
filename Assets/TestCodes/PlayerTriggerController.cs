using System;
using System.Collections;
using System.Collections.Generic;
using TestCodes;
using UnityEngine;

public class PlayerTriggerController : MonoBehaviour
{
    [SerializeField] private UESGameEvent onCoinCollected;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Coin Collected!");
            onCoinCollected.Raise(this, other.GetComponent<Coin>().coinCount);
            Destroy(other.gameObject);
        }
    }
}
