using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    // Declaration of public variables
    public float tumble;

    // Start is called just before any of the Update methods is called the first time (Since v1.0)
    public void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }


}