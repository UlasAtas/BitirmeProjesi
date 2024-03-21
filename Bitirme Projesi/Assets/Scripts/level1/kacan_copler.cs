using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kacan_copler : MonoBehaviour
{
    public GameObject panel;
    public int toplamKacan;
    public TextMeshProUGUI kacanlar;
    robot_haraket robotHareket;
    cop_yoketme2 copYoketme2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("robot"))
        {
            //Destroy(collision.gameObject);

            
            KacanGuncelle();
            

        }
    }
    private void KacanGuncelle()
    {
        
        toplamKacan++;
        kacanlar.text = "" + toplamKacan;
    }
    // Start is called before the first frame update
    void Start()
    {
        robotHareket = FindObjectOfType<robot_haraket>();
        copYoketme2 = FindObjectOfType<cop_yoketme2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (toplamKacan == 5)
        {
            panel.SetActive(true);
            robotHareket.hareketEt = false;
            copYoketme2.copOlustur = false;
        }
        
    }
}
