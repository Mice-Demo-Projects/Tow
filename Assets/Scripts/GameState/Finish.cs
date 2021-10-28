using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LevelManager.gameState = GameState.Finish;
            CanvasController.instance.victory.SetActive(true);
            print("win");
        }       
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LevelManager.gameState = GameState.Finish;
            CanvasController.instance.failure.SetActive(true);
            print("lose");
        }
    }
}
