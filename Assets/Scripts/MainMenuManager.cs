using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject StageButton;
    [SerializeField]
    private GameObject PanelStages;

    public void ActivateStageButton()
    {
        StageButton.SetActive(false);
        PanelStages.SetActive(true);
    }

    public void GoToLevelTutorial()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToLevelInGame()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
