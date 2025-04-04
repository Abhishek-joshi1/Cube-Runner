using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollission : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score scoreS;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            Destroy(other.gameObject);
            scoreS.AddScore(1);
        }
    }

    private void OnCollisionEnter(Collision otherObj)
    {
        if(otherObj.gameObject.tag == "Obstacles")
        {
            playerScript.enabled = false;
        }
    }
}
