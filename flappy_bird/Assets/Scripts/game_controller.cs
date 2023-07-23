using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_controller : MonoBehaviour
{
   
    public void loadGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }
    public void newGame()
    {
        SceneManager.LoadScene(0);
        GameObject.Find("new_game").SetActive(false);
    }

}
