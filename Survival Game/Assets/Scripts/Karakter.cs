using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{

    public float can, maxcan, candusmehizi;

    public float aclik, maxaclik, aclikdusmehizi;

    public float su, maxsu, sudusmehizi;

    public GameObject canbar, subar, aclikbar;

    void Start()
    {
        can = maxcan;
        aclik = maxaclik;
        su = maxsu;



    }

    void Update()
    {
        canbar.transform.localScale = new Vector2(can / maxcan, 1);
        aclikbar.transform.localScale = new Vector2(aclik / maxaclik, 1);
        subar.transform.localScale = new Vector2(su / maxsu, 1);

        if (can <= 0)
        {
            can = 0;
        }
        if (can > maxcan)
        {
            can = maxcan;
        }

        if (aclik <= 0)
        {
            aclik = 0;
        }
        if (aclik > maxaclik)
        {
            aclik = maxaclik;
        }
        if (aclik > 0)
        {
            aclik -= aclikdusmehizi * Time.deltaTime;
        }

        if (su <= 0)
        {
            su = 0;
        }

        if (su > maxsu)
        {
            su = maxsu;
        }
        if (su > 0)
        {
            su -= sudusmehizi * Time.deltaTime;
        }

        if (aclik <= 0 && su <= 0)
        {
            can -= candusmehizi * 2 * Time.deltaTime;
        }
        if (aclik <= 0 || su <= 0)
        {
            can -= candusmehizi * Time.deltaTime;
        }
    }
}
