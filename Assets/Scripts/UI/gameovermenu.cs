using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameovermenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    /*
   void Start()
    {
        Time.timeScale = .5f;

    }
    */
    void  Update()
    {
        if(Time.timeScale >= 0)
        {
            Time.timeScale = 0.05f;
        }
        
    }

    public void Reinciar()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);

    }

    public void QuitarJuego()
    {
        Application.Quit();

    }
}

