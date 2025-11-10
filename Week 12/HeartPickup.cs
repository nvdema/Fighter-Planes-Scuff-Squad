using UnityEngine;

public class HeartPickup : MonoBehaviour
{
    public float lifetime = 4f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null)
            {
                if (gm.currentLives < gm.maxLives)
                {
                    gm.currentLives += 1;
                    gm.ChangeLivesText(gm.currentLives);
                }
                else
                {
                    gm.AddScore(1); 
                }
            }

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            Destroy(gameObject, 0.1f);
        }
    }
}
