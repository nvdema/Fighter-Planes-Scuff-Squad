using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThree : MonoBehaviour
{
    //third new enemy

    public float speed = 2f; //speed of movement
    public float bobAmount = 0.5f; //how much movement
    public float bobSpeed = 3f; //speed of bobbing
 
    void Update()
    {
        //movement down the screen
        float downMovement = -speed * Time.deltaTime;
        //bobbing effect of enemy
        float upDown = Mathf.Sin(Time.time * bobSpeed) * bobAmount * Time.deltaTime;
        //combine movements
        transform.Translate(new Vector3(0, downMovement + upDown, 0));
        //destroy when off screen
        if (transform.position.y <-6.5f)
        {
            Destroy(gameObject);
        }
    }
}
