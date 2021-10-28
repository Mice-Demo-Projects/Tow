using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressMachine : MonoBehaviour
{
    public static PressMachine instance;
    private void Awake()
    {
        instance = this;
    }


    Rigidbody rb;
    Vector3 scaleChange;
    Rigidbody m_Rb;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        scaleChange = new Vector3(0.3f, 0.077f, 0.91f);
    }

    void Update()
    {
        MovementOfPressMachine();
    }
    void MovementOfPressMachine()
    {
        if (transform.position.y == 4)
        {
            rb.velocity = Vector3.down * 3f;
        }
        if (transform.position.y<1f)
        {
            rb.velocity = Vector3.up * 10f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            other.transform.localScale = scaleChange;
            TruckMovement.instance.isPressed = true;
            int b = other.transform.GetSiblingIndex();
            for (int i = TruckMovement.instance.transform.parent.childCount-1; i < TruckMovement.instance.transform.parent.childCount; i--)
            {
                if (i!=b)
                {
                    Debug.Log("I :: " + i + " b:: " + b);
                    TruckMovement.instance.transform.parent.GetChild(i).SetParent(null);
                    other.GetComponent<Collider>().enabled = false;
                    TruckMovement.instance.bodyParts.RemoveAt(i);
                }
                else if(i==b)
                {
                    break;
                }
                else
                {
                    break;

                }

            }
            Debug.Log("b " + b);
            m_Rb = other.GetComponent<Rigidbody>();
            m_Rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    
}
