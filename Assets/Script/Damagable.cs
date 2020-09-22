using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    public int hitpoints;

    public void GetHit(int damage) {
        hitpoints -= damage;

        if (hitpoints <= 0) {
            Destroy(gameObject);
        }
    }
}
