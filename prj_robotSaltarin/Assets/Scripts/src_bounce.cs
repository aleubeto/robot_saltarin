using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_bounce : MonoBehaviour
{
    public float bouncy = 600f;
    public bool breakable = false;
    void Start()
    {
    // Start is called before the first frame update
    }
    void Update()
    {
    // Update is called once per frame
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * bouncy);
        }
    }
}
