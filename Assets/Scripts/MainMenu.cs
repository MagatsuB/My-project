using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void StartCredit()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void MenuReturn()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
