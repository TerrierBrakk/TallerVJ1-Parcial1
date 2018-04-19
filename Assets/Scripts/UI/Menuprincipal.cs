using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuprincipal : MonoBehaviour {

    public void Iniciar()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitarJuego()
    {
        Application.Quit();

    }

}
