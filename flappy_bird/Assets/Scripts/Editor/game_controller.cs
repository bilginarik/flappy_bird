using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class game_controller : MonoBehaviour
{
   
    public void loadGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }
  

}
