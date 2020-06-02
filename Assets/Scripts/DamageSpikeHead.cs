using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSpikeHead : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Damage");
            Destroy(collision.gameObject);
        }
    }
}
