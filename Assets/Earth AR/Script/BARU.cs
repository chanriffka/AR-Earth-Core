using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BARU : MonoBehaviour
{
    public void PlayAR()
    {
        SceneManager.LoadScene("Play");
    }
    public void EarthInfo()
    {
        SceneManager.LoadScene("Info");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
