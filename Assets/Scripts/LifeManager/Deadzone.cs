using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadzone : LifeManager
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            SuddenDead();
        }
    }
}
