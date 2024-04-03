using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    
    private static int moneda;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
            Sumarmoneda();


        if (collision.tag == "Player")
        {
           // Sumarmoneda();
            Destroy(this.gameObject);
        }
        

    }

    private void Sumarmoneda()
    {
        moneda++;
        Debug.Log(moneda);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
