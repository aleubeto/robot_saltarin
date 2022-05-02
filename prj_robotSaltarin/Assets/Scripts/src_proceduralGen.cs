using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_proceduralGen : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    public GameObject breakablePrefab;
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
        // Método: Mover objetos existentes y crear plataformas especiales
        int probability = Random.Range(1,10);
        if(collision.gameObject.name.StartsWith("obj_platform1"))
        {
            if (probability == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
            }
            else if (probability == 2)
            {
                Destroy(collision.gameObject);
                Instantiate(breakablePrefab, new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f)));
            }
        }
        else if(collision.gameObject.name.StartsWith("obj_platform2"))
        {
            if (probability == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f)));
            }
            else if (probability == 2)
            {
                Destroy(collision.gameObject);
                Instantiate(breakablePrefab, new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
            }
        }
        else if(collision.gameObject.name.StartsWith("obj_platform3"))
        {
            if (probability == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
            }
            else if (probability == 2)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
            }
        }

        /* Método: Destruir y crear objetos
        if(Random.Range(1,10) == 1){
            myPlat = (GameObject)Instantiate(springPrefab, new Vector2(Random.Range(-5f, 5f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
        }
        else{
            myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5f, 5f), player.transform.position.y + (12 * Random.Range(0.5f, 0.7f))), Quaternion.identity);
        }
        Destroy(collision.gameObject);*/
    }
}
