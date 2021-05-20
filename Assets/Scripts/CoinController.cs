using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      //Cada vez que haya una collision con Scripter que se ejecute la funcion mandando 1 point
      // GameObject scripter = GameObject.Find("ScriptGenerator");
      // scripter.GetComponent<ScoreManager>().RaiseScore(1);
      //PlayerController.playerController.LifeUpdate(-1);
      ScoreManager.scoreManager.RaiseScore(1);
      Destroy(transform.parent.gameObject);
      // Destroy(gameObject);
    }
}
