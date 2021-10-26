using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public Canvas canvas;
    public GameObject options;
    public GameObject retry;
    public GameObject tapToStart;

    void Start()
    {
        
    }

    void Update()
    {
        if (LevelManager.gameState == GameState.BeforeStart)
        {
            options.SetActive(true);
            retry.SetActive(false);
            tapToStart.SetActive(true);
        }
        if (LevelManager.gameState == GameState.Normal)
        {
            options.SetActive(false);
            retry.SetActive(true);
            tapToStart.SetActive(false);
        }
        if (LevelManager.gameState == GameState.Finish)
        {
            print("finish");
        }
        if (Input.GetKeyDown("space"))
        {
            LevelManager.gameState = GameState.Finish;
        }
    }
}
