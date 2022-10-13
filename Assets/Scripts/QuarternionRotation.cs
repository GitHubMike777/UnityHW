using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuarternionRotation : MonoBehaviour
{
    public Vector3 RotationVelocity;    

    
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(RotationVelocity * Time.deltaTime);
        transform.rotation = deltaRotation * transform.rotation;
    }
}
