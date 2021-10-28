using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject truck;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - truck.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = truck.transform.position + offset;
    }
}
