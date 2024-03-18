using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cop_yoketme2 : MonoBehaviour
{
    public int toplamSkor = 0;

    // Skoru gösteren bir text nesnesi
    public TextMeshProUGUI skor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Çarpışan nesnenin "yok edilebilir" etiketine sahip olup olmadığını kontrol edin
        if (collision.gameObject.CompareTag("robot"))
        {
            Destroy(collision.gameObject);

            // Skoru güncelle
            SkorGuncelle();
            // Nesneyi yok edin
            
        }
    }

    public GameObject copKovası;

    void ParcalariOlustur()
    {
        // Rastgele bir konum oluşturmak için
        float x = Random.Range(-7.0f, 7.0f);
        float y = 10.0f;

        // Rastgele bir hız oluşturmak için
        float hiz = Random.Range(1.0f, 5.0f);

        // Parçayı oluşturmak için
        GameObject parca = Instantiate(copKovası, new Vector3(x, y, 0), Quaternion.identity);

        // Parçaya rastgele bir hız vermek için
        parca.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -hiz, 0);
    }
    void Start()
    {
        InvokeRepeating("ParcalariOlustur", 1, 2);
        //SkorGuncelle();
    }

    private void SkorGuncelle()
    {
        // Skoru text nesnesinde göster
        toplamSkor++;
        skor.text = "" + toplamSkor;
    }

}