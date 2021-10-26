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
    public GameObject victory;
    public GameObject failure;
    int cars;
    private void Awake()
    {
        victory.SetActive(false);
        failure.SetActive(false);
    }
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

#region temporary script
        if (LevelManager.gameState == GameState.Finish && cars >= 10)
        {
            victory.SetActive(true);
            print("win");

        }

        else if (LevelManager.gameState == GameState.Finish && cars < 10)
        {
            failure.SetActive(true);
            print("failure");
        }

        if (LevelManager.gameState == GameState.Normal && Input.GetKeyDown("space"))
        {
            LevelManager.gameState = GameState.Finish;
        }
        if (LevelManager.gameState == GameState.Normal &&  Input.GetKeyDown("q"))
        {
            cars++;
        }
        print(cars);
        #endregion
    
    }
}
