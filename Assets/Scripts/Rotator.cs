using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    // Update is called every frame, if the MonoBehaviour is enabled (Since v1.0)
    public void Update()
    {
        transform.Rotate(new Vector3(15, 20, 45) * Time.deltaTime);
    }
}
