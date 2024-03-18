using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kacan_copler : MonoBehaviour
{
    public GameObject panel;
    public int toplamKacan;
    public TextMeshProUGUI kacanlar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Çarpışan nesnenin "yok edilebilir" etiketine sahip olup olmadığını kontrol edin
        if (collision.gameObject.CompareTag("robot"))
        {
            //Destroy(collision.gameObject);

            // Skoru güncelle
            KacanGuncelle();
            // Nesneyi yok edin

        }
    }
    private void KacanGuncelle()
    {
        // Skoru text nesnesinde göster
        toplamKacan++;
        kacanlar.text = "" + toplamKacan;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toplamKacan == 5)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }
}
