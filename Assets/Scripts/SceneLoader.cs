using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] TriggerRespawn triggerRespawn;

    private void Start()
    {
        triggerRespawn = FindObjectOfType<TriggerRespawn>();
    }
    public void ReloadScene()
    {
        if (triggerRespawn.GetRespawnTrigger() == true)
        {
            SceneManager.LoadScene(2);
            Time.timeScale = 1;  // "starts" time 
        }
        else
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame ()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}



