﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(gameObject.transform.position, transform.TransformDirection(Vector3.down) * 0.2f, Color.yellow);
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, transform.TransformDirection(Vector3.down), 0.2f);
		if(hit.collider != null && hit.collider.gameObject.CompareTag("Ground")){
			hit.collider.isTrigger = false;
		}
    }
}
