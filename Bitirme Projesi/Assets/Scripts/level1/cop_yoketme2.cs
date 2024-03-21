using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cop_yoketme2 : MonoBehaviour
{
    public int toplamSkor = 0;
    public bool copOlustur;

    
    public TextMeshProUGUI skor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("robot"))
        {
            Destroy(collision.gameObject);

            
            SkorGuncelle();
            

        }
    }

    public GameObject copKovası;

    void ParcalariOlustur()
    {
        
        
        float x = Random.Range(-7.0f, 7.0f);
        float y = 10.0f;

        
        float hiz = Random.Range(1.0f, 5.0f);

        
        GameObject parca = Instantiate(copKovası, new Vector3(x, y, 0), Quaternion.identity);

        
        parca.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -hiz, 0);
    }
    void Start()
    {
        copOlustur = true;
        if (copOlustur)
        {
            InvokeRepeating("ParcalariOlustur", 1, 2);

        }
        //SkorGuncelle();
    }

    private void SkorGuncelle()
    {
        
        toplamSkor++;
        skor.text = "" + toplamSkor;
    }

}