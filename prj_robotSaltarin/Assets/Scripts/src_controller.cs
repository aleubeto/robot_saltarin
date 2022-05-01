using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class src_controller : MonoBehaviour
{
    public Text txt_score;
    private float topScore = 0.0f;
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(rb2d.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }
        txt_score.text = "Score: " + Mathf.Round(topScore).ToString();
    }
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
    }
}
