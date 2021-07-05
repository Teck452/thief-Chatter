using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Accesses the Unity scene manager

public class MainMenu : MonoBehaviour
{
    public void Play() // Load's the game scene
    {
        SceneManager.LoadScene("TestEnvironment");
    }

    public void Quit() // Quit's the application
    {
        Application.Quit();
    }

    public void ReturnToMainMenu() // Return's to Main menu
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Credits() // Load's the Credits menu
    {
        SceneManager.LoadScene("CreditsMenu");
    }
}
