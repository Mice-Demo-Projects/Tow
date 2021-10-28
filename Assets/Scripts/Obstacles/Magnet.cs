using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
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
        MagnetFunc();
    }
    void MagnetFunc()
    {
        if (transform.position.x > 15)
        {
            rb.velocity = Vector3.left * 10f;
        }
        if (transform.position.x < 5.20f)
        {
            rb.velocity = Vector3.right * 10f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            other.transform.localScale = scaleChange;
            TruckMovement.instance.bodyParts.Remove(other.transform);
            other.transform.parent = null;
            m_Rb = other.GetComponent<Rigidbody>();
            m_Rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
