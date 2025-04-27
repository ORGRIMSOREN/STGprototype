using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy01 : MonoBehaviour
{
    public GameObject explosion;
    GameContorller Gamecontorller;
    public GameObject bulletsPf;
    
    void Start()
    {
        Gamecontorller = GameObject.Find("GameContorller").GetComponent<GameContorller>();
        InvokeRepeating("shot", 2f, 1f);  
    }

    
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime, 0);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")==true)
        {
            Instantiate(explosion, collision.transform.position, transform.rotation);
            Gamecontorller.GameOver();
        }
        else if (collision.CompareTag("Bullet") == true)
        {
            Gamecontorller.AddScores();
        }
        else if (collision.CompareTag("enemybullet")==true)
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(collision.gameObject);


    }

    void shot()
    {
        Instantiate(bulletsPf, transform.position, transform.rotation);
    }

}
