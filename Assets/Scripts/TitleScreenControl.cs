using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Quick and dirty way to start game
public class TitleScreenControl : MonoBehaviour
{
    public void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Tell the game manager that we are going to paly
    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        GameManager.gm.ChangeGameState(GameManager.GameStates.PLAYING);
    }

    // If player presses anything, start the game
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            // Loads to Game   
            SceneManager.LoadScene(System.Enum.GetName(typeof(Constants.Levels), Constants.Levels.Game)); 
        }
    }
}
