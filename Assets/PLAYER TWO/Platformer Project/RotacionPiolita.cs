using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPiolita : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
