using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_proceduralGen : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
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
        if(Random.Range(1,10) == 1){
            myPlat = (GameObject)Instantiate(springPrefab, new Vector2(Random.Range(-5f, 5f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
        }
        else{
            myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5f, 5f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
        }
        Destroy(collision.gameObject);
    }
}
