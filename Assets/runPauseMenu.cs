using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class runPauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject QuitPopOut;
    public GameObject pauseFirstButton, QuitFirstButton, pauseClosedButton;
    public AudioSource audio;

    void start()
    {
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            pauseMenuActive();

        }


    }
    private void pauseMenuActive()
    {
        audio.Pause();
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        //EventSystem.current.SetSelectedGameObject(pauseFirstButton);
    }

    public void resume()
    {
        audio.Play();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void quit()
    {
        QuitPopOut.SetActive(true);
        quitPopOutMenu();
    }

    private void quitPopOutMenu()
    {

        EventSystem.current.SetSelectedGameObject(null);
        //EventSystem.current.SetSelectedGameObject(QuitFirstButton);
    }

    public void No()
    {
        QuitPopOut.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        //EventSystem.current.SetSelectedGameObject(pauseClosedButton);
    }

    public void Yes()
    {
        SceneManager.LoadScene("BoM_Map");
    }



}
