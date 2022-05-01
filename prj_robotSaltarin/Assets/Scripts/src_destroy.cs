using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    private GameObject myPlat;
    void Start()
    {
    // Start is called before the first frame update
    }

    void Update()
    {
    // Update is called once per frame
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5f, 5f), player.transform.position.y + (14 * Random.Range(0.5f, 1f))), Quaternion.identity);
        Destroy(collision.gameObject);
    }
}
