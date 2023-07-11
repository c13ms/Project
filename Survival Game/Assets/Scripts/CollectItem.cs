using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{
    public Transform Player;
    public GameObject Item;
    public bool mesafe;

    void Update()
    {
        if (Vector3.Distance (transform.position, Player.position) < 2.8f)
        {
            mesafe = true;
        }
        else
        {
            mesafe = false;
        }
        if (mesafe == true && Input.GetKey(KeyCode.F))
        {
            Item.SetActive(true);
            Destroy(gameObject);
        }
    }
   
    private void OnGUI()
    {
        
    }

}
