using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    // Declaration of public variables
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundary")
        {
            return;
        }

        Instantiate(explosion, other.transform.position, other.transform.rotation);

        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, transform.position, transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
