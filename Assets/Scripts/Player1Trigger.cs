using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Trigger : MonoBehaviour
{
    public Collider collider;

    // Update is called once per frame
    void Update()
    {
        if(Player1Actions.Contact == false)
        {
            collider.enabled = true;

        }
        else
        {
            collider.enabled = false;
        }
    }
         void OnTriggerEnter(Collider other) {
            if (other.gameObject.CompareTag("Player1"))
            {
                Player1Actions.Contact = true;
            }
        }
    }

