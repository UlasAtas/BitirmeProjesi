using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cop_yoketme1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("robot"))
        {
            // Nesneyi yok edin
            Destroy(collision.gameObject);
        }
    }

    public GameObject copKovası;

    //void ParcalariOlustur()
    //{
    
    //    float x = Random.Range(-8.0f, 8.0f);
    //    float y = 10.0f;

    
    //    float hiz = Random.Range(1.0f, 5.0f);

    
    //    GameObject parca = Instantiate(copKovası, new Vector3(x, y, 0), Quaternion.identity);

    
    //    parca.GetComponent<Rigidbody>().velocity = new Vector3(0, -hiz, 0);
}
    //void Start()
    //{
    //    InvokeRepeating("ParcalariOlustur", 1, 2);
    //}