using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerships : MonoBehaviour
{
    public Transform firePoint; //?o?g??m
    public float speed = 3f;
    public GameObject bulletPrefab;
    public float xRange = 2;
    public float yRange = 2;
    public GameObject explosion;
    GameContorller Gamecontorller;
    public AudioClip firesound;
    AudioSource audioSource;
    

    private void Start()
    {
        //InvokeRepeating("Fire", 0.5f, 0.15f);
        Gamecontorller = GameObject.Find("GameContorller").GetComponent<GameContorller>();
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {

        Move();
        Fire();
      
    }

    private void Move()
    {
        float X = Input.GetAxisRaw("Horizontal");
        float Y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(X, Y, 0) * Time.deltaTime * speed;
        if (transform.position.x>xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, 0);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, 0);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x,yRange, 0);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x,-yRange, 0);
        }
    }
    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            PlaySound(firesound);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemybullet") == true)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Gamecontorller.GameOver();
            
        }
        
    }
    void PlaySound(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
    
}
