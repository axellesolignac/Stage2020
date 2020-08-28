using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaBehavior : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    public float VulnerabilityTime;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        SetVelocity(vitesse);
        StartCoroutine(AddSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isGrounded == true){
            Jump();
        }
    }

    void Jump() {
        rb.velocity += new Vector2(0, maxJump);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col) {
        if(col.gameObject.CompareTag("Ground")){
            isGrounded = false;
        }
    }

    void SetVelocity(float xVelocity, float yVelocity){
        rb.velocity = new Vector2(0, 0);
        rb.velocity += new Vector2(xVelocity, yVelocity);
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Obstacle")){
            StartCoroutine(ObstacleFind());
        }
    }
    IEnumerator ObstacleFind(){
        yield return new WaitForSeconds (0.1f);
        GameObject.FindWithTag("Monster").GetComponent<MonsterSystem>().Closer();
        SetVelocity(vitesse/1.5f);
        yield return new WaitForSeconds (0.5f);
        SetVelocity(vitesse);
        yield return new WaitForSeconds (VulnerabilityTime);
        GameObject.FindWithTag("Monster").GetComponent<MonsterSystem>().Further();
        
    }
    IEnumerator AddSpeed(){
        while(vitesse < 16){
            yield return new WaitForSeconds (1);
            vitesse += 0.1f;
            SetVelocity(vitesse);
        }  
    }
    void SetVelocity(float speed){
        rb.velocity = new Vector2 (0,rb.velocity.y);
        rb.velocity = new Vector2 (speed,rb.velocity.y);
    }
}
