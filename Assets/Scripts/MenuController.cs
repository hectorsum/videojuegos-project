using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
  //GameObject -> quien contenga el script, sera tomado como el GameObject
  public GameObject menuOpciones;
  public void MenuOpciones(){
    Time.timeScale = 0;
    menuOpciones.SetActive(true);
  }
  public void Volver(){
    Time.timeScale = 1;
    menuOpciones.SetActive(false);
  }
  public void Salir(){
    Application.Quit();

  }
}
