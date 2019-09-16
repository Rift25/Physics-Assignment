using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    

    void Start()
    {
        pauseMenuUI.SetActive(false);  //hides the main menu on start
        Time.timeScale = 1f;           //unfreezes time
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Escape))    //when Escape is pressed checks to see if the game is paused or not
        {
            if (GameIsPaused == true)
            {
                Resume();
            }
            else if (GameIsPaused == false)
            {
                Pause();
            }
        }
    }

    public void Resume()    //if game is paused resumes the game
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()           //if game is playing pauses the game
    {
        
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(int sceneIndex)     //loads start menu once menu is pressed in the main menu
    {
        //SceneManager.LoadScene("MainMenu");
        
        {
            SceneManager.LoadScene (sceneIndex);
        }
    }

    public void QuitGame()    //quits the game (the code for this is in <QuitOnClick.cs> )
    {
        Debug.Log("Quiting game...");
    }
}
