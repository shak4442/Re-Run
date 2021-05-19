using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< Updated upstream
    public Vector2 speed = new Vector2(10, 10);
=======
    public Vector2 speed = new Vector2(7, 7);
>>>>>>> Stashed changes
    public Transform spawnpoint;
    Collider2D play;

    void Start()
    {
        play = GetComponent<Collider2D>();
    }

<<<<<<< Updated upstream
    void OnCollisionEnter2D(Collision2D col)
    {
        //detects collision with coin and adds score
=======
    void Update()
    {
        //movement from inputs
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(speed.x * inputX, speed.y * inputY);

        movement *= Time.deltaTime;

        transform.Translate(movement);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
>>>>>>> Stashed changes
        if (col.gameObject.tag == "Coin"){
            Score.scoreAmount ++;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Enemy"){
            Deaths.deathAmount ++;
            Respawn();
        }
<<<<<<< Updated upstream
=======
        
>>>>>>> Stashed changes
        if (col.gameObject.tag == "P-Speed"){
            
            Destroy(col.gameObject);
            StopCoroutine(SpeedUp());  
            StartCoroutine(SpeedUp());
        }

        if (col.gameObject.tag == "P-Slow"){
            
            Destroy(col.gameObject);
            StopCoroutine(SpeedDown());  
            StartCoroutine(SpeedDown());
        }

        if (col.gameObject.tag == "P-Invulnerable"){
            
            Destroy(col.gameObject);
            StopCoroutine(Invulnerable());  
            StartCoroutine(Invulnerable());
        }
    }

    IEnumerator SpeedUp()
    {
        speed = speed *1.7f;
        yield return new WaitForSeconds(5f);
        speed = speed /1.7f;
<<<<<<< Updated upstream
        
=======
>>>>>>> Stashed changes
    }
    IEnumerator SpeedDown()
    {
        speed = speed /1.5f;
        yield return new WaitForSeconds(5f);
        speed = speed *1.5f;
    }

    IEnumerator Invulnerable()
    {
        play.enabled = !play.enabled;
        yield return new WaitForSeconds(5f);
        play.enabled = !play.enabled;
    }
    
    void Respawn() 
    {
        this.transform.position = spawnpoint.position;
    }
<<<<<<< Updated upstream

    void Update()
    {
        //movement from inputs
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);

    }
=======
>>>>>>> Stashed changes
}
