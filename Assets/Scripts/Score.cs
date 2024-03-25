using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int eggScore = 10;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Egg"))
        {
            AddScore.instance.Adddiem(eggScore);
            Destroy(collision.gameObject);
        }
    }
}
