using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    // Declaration of public variables
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;

    // Declaration of public variables
    private GameController gameController;

    // Start is called just before any of the Update methods is called
    public void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if(gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }

        if(gameControllerObject = null)
        {
            Debug.Log("Cannot find 'GameController' script.");
        }
    }

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
            gameController.GameOver();
        }
        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
