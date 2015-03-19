using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
    // Declaration of public variables
    public float lifeTime;

    // Start is called just before any of the Update methods is called the first time (Since v1.0)
    public void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
