using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float speed = 7f;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {        
            float horizontal = Input.GetAxisRaw("Horizontal");
            rb2d.velocity = new Vector2(horizontal * speed, 0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7f, 7f), transform.position.y, 0);
    }
}
