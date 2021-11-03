using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerMovement PlayerMovement;
    public GameObject particles;

        private void Start()
    {
        PlayerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            PlayerMovement.Die();

            Vector3 otherPosition = this.transform.position;

            Instantiate(particles, this.transform.position, Quaternion.identity);
        }
    }
}