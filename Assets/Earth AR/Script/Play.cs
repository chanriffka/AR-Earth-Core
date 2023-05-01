using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
  public void Info()
  {
    SceneManager.LoadScene("Info");
  }
  public void Kembali()
  {
    SceneManager.LoadScene("MainMenu");
  }
}
