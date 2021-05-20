using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
  public static ScoreManager scoreManager;
  public Text scoreText;
  int score = 0;
  private void Start(){
    if(!scoreManager){
      scoreManager = this;
      DontDestroyOnLoad(gameObject);
    }else{
      Destroy(gameObject);
    }
  }
  private void Update(){
    if(!scoreText){
      //Busca Text "Points"
      scoreText = GameObject.Find("Points").GetComponent<Text>();
    }
  }
  public void RaiseScore(int points){
    score += points;
    Debug.Log(score);
    scoreText.text = score + "";
    if (score == 5){
      // SceneManager.LoadScene("Scene2");
    }
  }
}
