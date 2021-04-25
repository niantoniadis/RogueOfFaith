using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScene : MonoBehaviour
{
    // ui elements
    public GameObject MenuPanel;
    public GameObject HideButton;
    public GameObject InstructionsText;
    public GameObject InstructionsButton;
    public GameObject ResumeButton;
    public GameObject MainMenuButton;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (InstructionsText.activeSelf)
            {
                HideInstructions();
            }
            else if (MenuPanel.activeSelf)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    /// <summary>
    /// Pauses the game
    /// </summary>
    public void PauseGame()
    {
        MenuPanel.SetActive(true);

        // pause code here
    }

    /// <summary>
    /// Sends the player back to the title screen
    /// </summary>
    public void ToTitleScreen()
    {
        SceneManager.LoadScene("TitleScene");
    }

    /// <summary>
    /// Puts the player back in the game
    /// </summary>
    public void Resume()
    {
        MenuPanel.SetActive(false);

        // resume code here
    }

    /// <summary>
    /// Shows the player the instructions again
    /// </summary>
    public void Instructions()
    {
        InstructionsText.SetActive(true);
        HideButton.SetActive(true);
        ResumeButton.SetActive(false);
        MainMenuButton.SetActive(false);
        InstructionsButton.SetActive(false);
    }

    /// <summary>
    /// hides the instructions again
    /// </summary>
    public void HideInstructions()
    {
        InstructionsText.SetActive(false);
        HideButton.SetActive(false);
        ResumeButton.SetActive(true);
        MainMenuButton.SetActive(true);
        InstructionsButton.SetActive(true);
    }
}