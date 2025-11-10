using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCoin : MonoBehaviour
{
    public float lifetime = 5f;
    private AudioSource coinSound;

    void Start()
    {
        coinSound = GetComponent<AudioSource>();
        Destroy(gameObject, lifetime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (coinSound !=null)
                coinSound.Play();

            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null)
            {
                gm.AddScore(1);
            }
            
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;


            Destroy(gameObject, 0.5f);
        }
    }
}
