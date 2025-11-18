using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glider : MonoBehaviour
{
    public float fallingSpeed = 2f;
    public float zigZagAmount = 3f;
    public float zigZagSpeed = 1f;
    public bool goingUp;
    public float speed;
    private float startX;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goingUp)
        {
            transform.position = new Vector3(
           startX + Mathf.Sin(Time.time * zigZagSpeed) * zigZagAmount,
           transform.position.y - fallingSpeed * Time.deltaTime,
           transform.position.z
       );
        }
        else if (goingUp == false)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (transform.position.y >= gameManager.verticalScreenSize * 1.25f || transform.position.y <= -gameManager.verticalScreenSize * 1.25f)
        {
            Destroy(this.gameObject);
        }
    }
}
