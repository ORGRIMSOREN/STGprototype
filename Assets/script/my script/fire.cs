using UnityEngine;

public class fire : MonoBehaviour
{
    #region Дж¦м
    [SerializeField]
    private int bulletAmount=3;
    private float startAngle = 90f, endAngle=270f;
    private Vector2 bulletMoveDiection;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, 2f);

    }

    private void Fire()
    {
        float anglestep = (endAngle - startAngle) / bulletAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletAmount; i++)
        {
            float buldirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float buldiry = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVoctor = new Vector3(buldirX, buldiry, 0f);
            Vector2 bulDir = (bulMoveVoctor - transform.position).normalized;

            
            GameObject bul =Bullets.WeaponSystem.Getbullet();  
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<bullet>().SetMoveDirection(bulDir);

            angle += anglestep;

        }
    }
}
