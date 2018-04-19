using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameovermenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
   
   void Start()
    {
        Time.timeScale = 0f;

    }
<<<<<<< HEAD
   
=======
    */
    void  Update()
    {
        if(Time.timeScale >= 0)
        {
            Time.timeScale = 0.05f;
        }
        
    }
>>>>>>> 558907813622c11cddb62b6befa1909e5932a6f7

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

