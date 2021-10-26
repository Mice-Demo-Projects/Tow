using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    #region instance structure
    public static TruckMovement instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void GoForward()
    {
        rigidbody.AddForce(transform.forward*0.5f);
    }

    void Update()
    {
        if (LevelManager.gameState==GameState.Normal)
        {
            GoForward();
        }
    }
    public void Swiper(float xLine)
    {
        Vector3 pos = new Vector3(xLine, 0, 0);
        transform.position += pos * 2;
        Vector3 clampPos = transform.position;
        clampPos.x= Mathf.Clamp(clampPos.x,-1.25f,1.25f);
        transform.position = clampPos;
    }
}
