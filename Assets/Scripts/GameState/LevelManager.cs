using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region singleton
    public static LevelManager instance;
    public static GameState gameState;
    private void Awake()
    {
        instance = this;
    }
    #endregion
}
