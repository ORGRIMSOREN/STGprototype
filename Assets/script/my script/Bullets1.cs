using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets1 : MonoBehaviour
{
    public float Speed=3f;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Speed);
        
    }
}
