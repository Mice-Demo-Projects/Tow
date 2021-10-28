using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stacking : MonoBehaviour
{
    public static Stacking instance;
    TruckMovement _truckMovement;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        _truckMovement = TruckMovement.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            PickUp(other.gameObject);
        }
    }
    public void PickUp(GameObject pickedCar)
    {
        pickedCar.transform.parent = _truckMovement.transform.parent;
        Vector3 truckPos = new Vector3(_truckMovement.transform.localPosition.x,
            _truckMovement.transform.localPosition.y, (_truckMovement.bodyParts.Count + 1) * -_truckMovement.minDistance);
        pickedCar.transform.localPosition = truckPos;
        _truckMovement.bodyParts.Add(pickedCar.transform);

    }
}
