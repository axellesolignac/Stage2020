using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.CompareTag("Player")){
            col.gameObject.GetComponent<CharaBehavior>().isGrounded = false;
            Rigidbody2D rb = col.gameObject.GetComponent<Rigidbody2D>();
            Vector3 velo = rb.velocity;
            rb.velocity += new Vector2(0, -velo.y);
            rb.velocity += new Vector2(0, 25);
            Destroy(gameObject);
        }
    }
}
