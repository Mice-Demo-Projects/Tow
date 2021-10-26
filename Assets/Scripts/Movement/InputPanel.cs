using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputPanel : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    TruckMovement truckMovement;
    
    void Start()
    {
        truckMovement = TruckMovement.instance;
    }

    void Update()
    {
        
    }
    public void OnDrag(PointerEventData data)
    {
        truckMovement.Swiper(data.delta.x / Screen.width);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (LevelManager.gameState == GameState.BeforeStart)
        {
            LevelManager.gameState = GameState.Normal;
        }
    }
}
