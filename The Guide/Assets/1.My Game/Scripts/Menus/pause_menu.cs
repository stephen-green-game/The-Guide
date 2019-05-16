using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause_menu : MonoBehaviour
{
    public  bool game_paused = false;
    public GameObject pause_menu_ui;
    public Canvas current_ui;


    private void Start()
    {
        pause_menu_ui.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (game_paused == true)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }



    public void resume()
    {
        current_ui.GetComponent<CanvasGroup>().alpha = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pause_menu_ui.SetActive(false);
        Time.timeScale = 1f;
        game_paused = false;
    }


    public void pause()
    {
        current_ui.GetComponent<CanvasGroup>().alpha = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pause_menu_ui.SetActive(true);
        Time.timeScale = 0f;
        game_paused = true;

    }

    public void menu()
    {
        SceneManager.LoadScene("Start");

    }


    public void quite()
    {
        Application.Quit();

    }


    
}
