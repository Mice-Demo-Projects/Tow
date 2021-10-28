using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    #region Variables
    public static TruckMovement instance;


    [System.NonSerialized] public List<Transform> bodyParts = new List<Transform>();

    [System.NonSerialized] public float minDistance = .75f;
    float speed = 0.04f;
    float dis;
    Transform curBodyPart;
    Transform PrevBodyPart;
    [System.NonSerialized] public bool isPressed = false;
    #endregion

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        bodyParts.Add(transform);
    }
    void GoForward()
    {
        transform.parent.position += transform.parent.forward * speed;
    }

    void Update()
    {
        if (LevelManager.gameState==GameState.Normal)
        {
            GoForward();
            if (bodyParts.Count > 1)
            {
                Move();
            }
        }
    }
    public void Swiper(float xLine)
    {
        Vector3 pos = new Vector3(xLine, 0, 0);
        transform.localPosition += pos * 2;
        Vector3 clampPos = transform.localPosition;
        clampPos.x= Mathf.Clamp(clampPos.x,-1.25f,1.25f);
        transform.localPosition = clampPos;
    }
    public void Move()
    {
        float curspeed = 3.5f;
        for (int i = 1; i < bodyParts.Count; i++)
        {

            curBodyPart = bodyParts[i];
            PrevBodyPart = bodyParts[i - 1];

            dis = Vector3.Distance(PrevBodyPart.localPosition, curBodyPart.localPosition);

            Vector3 newpos = curBodyPart.localPosition;

            newpos.y = bodyParts[0].localPosition.y;
            newpos.x = PrevBodyPart.localPosition.x;
            newpos.z = (i + 1) * -minDistance;

            float T = Time.deltaTime * dis / minDistance * curspeed;

            if (T > 0.5f)
                T = 0.5f;

            curBodyPart.localPosition = Vector3.Slerp(curBodyPart.localPosition, newpos, T);
            curBodyPart.rotation = Quaternion.Slerp(curBodyPart.rotation, PrevBodyPart.rotation, T);
            if (isPressed)
            {
            }

        }
    }
}
