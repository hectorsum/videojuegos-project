using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
  public static PlayerController playerController; //Para utilizar todas las variables en otros archivos
  public Image barraDeVida;
  public float vidaActual = 10;
  public float vidaMax = 10;

  bool canJump;
  Rigidbody2D p_Rigidbody2D;
  Animator p_Animator;
  SpriteRenderer p_SpriteRenderer;
  // Start is called before the first frame update
  void Start()
  {
    //Para tener acceso al Script
    if(!playerController){
      playerController = this;
      DontDestroyOnLoad(gameObject);
    }else{
      Destroy(gameObject);
    }
    p_Rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    p_Animator = gameObject.GetComponent<Animator>();
    p_SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey("left")){
      p_Rigidbody2D.AddForce(new Vector2(-500f * Time.deltaTime, 0));
      p_Animator.SetBool("moving", true);
      p_SpriteRenderer.flipX = true;
    }
    if (Input.GetKey("right")){
      p_Rigidbody2D.AddForce(new Vector2(500f * Time.deltaTime, 0));
      p_Animator.SetBool("moving", true);
      p_SpriteRenderer.flipX = false;
    }
    if(!Input.GetKey("left") && !Input.GetKey("right")){
      p_Animator.SetBool("moving", false);
    }
    if (Input.GetKey("up") && canJump){
      canJump = false;
      p_Rigidbody2D.AddForce(new Vector2(0, 150f));
    }
    if(!barraDeVida){
      barraDeVida = GameObject.Find("Life").GetComponent<Image>();
      barraDeVida.fillAmount = vidaActual / vidaMax;
    }
  }
  public void LifeUpdate(int cant){
    vidaActual+=cant;
    barraDeVida.fillAmount = vidaActual / vidaMax;
  }
  private void OnCollisionEnter2D(Collision2D collision){
    if (collision.transform.tag == "ground"){
        canJump = true;
    }
  }
}
