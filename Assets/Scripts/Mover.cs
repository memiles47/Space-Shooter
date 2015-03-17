using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    // Declare public variables
    public float speed;

    // Start is called just before any of the Update methods is called the first time (Since v1.0)
    public void Start()
    {
        GetComponent<Rigidbody>().velocity = GetComponent<Transform>().forward * speed;
    }
}
