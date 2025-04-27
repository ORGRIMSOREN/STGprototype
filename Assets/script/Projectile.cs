using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 0.3f;
    public float Damage = 5.0f;
    

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Speed);
        if (transform.position.y > 3)
        {
            Destroy(gameObject);
        }
    }

   
}
