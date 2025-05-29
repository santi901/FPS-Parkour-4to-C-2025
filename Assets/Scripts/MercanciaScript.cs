using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{

    bool collisionWithPlayer(Collision c)
    {
       return c.gameObject.name == "Player";
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collisionWithPlayer(collision))
        {
            Destroy(gameObject);
        }
    }
}
