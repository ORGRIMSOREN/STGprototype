using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    #region Äæ¦ì
    public static Bullets WeaponSystem;

    [SerializeField]
    private GameObject weaponPool;
    private bool notEnoughWeapon = true;


    private List<GameObject> bullets;


    #endregion

    #region ¤èªk
    private void Awake()
    {
        WeaponSystem = this;

    }

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();

    }

    public GameObject Getbullet()
    {
        {
            if (bullets.Count > 0)
            {
                for (int i = 0; i < bullets.Count; i++)
                {
                    if (!bullets[i].activeInHierarchy)
                    {
                        return bullets[i];
                    }

                }
            }

            if (notEnoughWeapon)
            {
                GameObject bul = Instantiate(weaponPool);
                bul.SetActive(false);
                bullets.Add(bul);
                return bul;
            }

        }
        return null;
    }
}
