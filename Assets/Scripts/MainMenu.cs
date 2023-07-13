using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //public int GetButtonValue()
    //{
    //    return this.name;
    //}

    //public void ChooseLevel(int index)
    //{
    //    SceneManager.LoadScene(1);
    //}

    public void QuitGame()
    {
        Application.Quit();
    }
}
