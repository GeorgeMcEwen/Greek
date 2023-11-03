using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject startButton;
    public void PlayGame()
    {
        SceneManager.LoadScene("Testing");
    }
  public void QuitGame()
    {
        Application.Quit();
    }

  public void StartMenu(GameObject objToEnable)
    {
        objToEnable.SetActive(true);
        Destroy(startButton);
    }



}
