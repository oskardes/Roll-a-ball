using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject option;
    public GameObject volumeMenu;
    public void StartGame()
    {
        SceneManager.LoadScene("Scena1", LoadSceneMode.Single);
    }

    public void ShowOption()
    {
        option.SetActive(true);
        mainPanel.SetActive(false);

    }

    public void ExitGame()
    {
        Debug.Log("Application quit!");
        Application.Quit();
    }

    public void ReturnToBegin()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void ReturntoMenu()
    {
        option.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void ChangeVolume()
    {
        option.SetActive(false);
        volumeMenu.SetActive(true);
    }

    public void ReturnToMenuVolume()
    {
        volumeMenu.SetActive(false);
        option.SetActive(true);
    }
}
