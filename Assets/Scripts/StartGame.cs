using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject startGameButton;
    
    public void StartPlaying()
    {
        SceneManager.LoadScene(1);
    }
}
