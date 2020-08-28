using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSystem : MonoBehaviour
{
    public GameObject player;
    public GameObject canvas;
    public Animator animator;
    public bool isKilling = false;
    private int state = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (player.transform.position.x - 10.27f, -7.76f, -0.66f);
        if(isKilling){
            KillPlayer();
        }
    }

    public void Further(){
        state --;
        animator.SetInteger("State", state);
    }

    public void Closer(){
        state ++;
        animator.SetInteger("State", state);
    }

    public void KillPlayer(){
        canvas.GetComponent<CanvaManager>().GameOver();
    }
}
