using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Trigger : MonoBehaviour
{
    public int damage = -10;
    public Collider collider;

    // Update is called once per frame
    void Update()
    {
        if (Player1Actions.Contact == false)
        {
            collider.enabled = true;

        }
        else
        {
            collider.enabled = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Player2Actions.Contact = true;
        }
        /*

        var p1hs = collison.GetComponent<Player1HealthSystem>;
        if (p1hs != null)
        {
            p1hs.takeDamage(damage);
        }
        */


    }
}
