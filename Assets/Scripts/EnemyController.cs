using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      //Cada vez que haya una collision con Scripter que se ejecute la funcion mandando 1 point
      PlayerController.playerController.LifeUpdate(-1);
      //Destroy(transform.parent.gameObject);
      // Destroy(gameObject);
    }
}
