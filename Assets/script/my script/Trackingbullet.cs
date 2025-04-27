using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trackingbullet : MonoBehaviour
{
    public float Speed = 3f;
    public GameObject target;
    void Update()
    {


        


        transform.position += new Vector3(0, -3, 0) * Time.deltaTime;
        if (transform.position.y < -3)
        {
            Destroy(gameObject);
        }
    }





}
