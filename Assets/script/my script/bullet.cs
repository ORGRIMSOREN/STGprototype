using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    #region Äæ¦ì
    private Vector2 moveDirection;
    private float moveSpeed;

    #endregion
    #region ¤èªk
    private void OnEnable()
    {
        Invoke("Destroy", 3f);
    }
    void Start()
    {
        moveSpeed = 0.5f;
    }

    
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

    }

    public void SetMoveDirection(Vector2 Bullet)
    {
        moveDirection = Bullet;
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
    #endregion





}
