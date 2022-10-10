using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float speed = 10f;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(new Vector2(0, -500));
        }

        rb2d.velocity = speed * (rb2d.velocity.normalized);

        if (GameObject.FindGameObjectsWithTag("Target").Length == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name.StartsWith("Bottom"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {        
        if (coll.gameObject.CompareTag("Target"))
        {
            
            Destroy(coll.gameObject);
        }
        
    }
}
