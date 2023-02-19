using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

    [SerializeField] private GameObject botonPausa;

    [SerializeField] private GameObject menuPausa;

   public void pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void resume()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void GotoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
