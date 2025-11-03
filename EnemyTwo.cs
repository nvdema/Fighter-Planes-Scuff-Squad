using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    public float fallingSpeed = 2f;
    public float zigZagAmount = 3f;
    public float zigZagSpeed = 1f;

    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(
            startX + Mathf.Sin(Time.time * zigZagSpeed) * zigZagAmount,
            transform.position.y - fallingSpeed * Time.deltaTime,
            transform.position.z
        );

        if (transform.position.y < -6.5f) Destroy(gameObject);
    }
}
