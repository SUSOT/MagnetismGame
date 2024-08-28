using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void InGame()
    {
        SceneManager.LoadScene("CM");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
