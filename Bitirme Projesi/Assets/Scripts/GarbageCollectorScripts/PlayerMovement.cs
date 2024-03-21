using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Rigidbody2D rb; 
    public GameObject cop;
    public float bekleSure, posX, posY;
    Transform theTransform, spawnPoint;
    public bool olusturdu;
    public int toplamSkor = 0;
    public TextMeshProUGUI skor;
    Vector3 targetPosition;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        spawnPoint = cop.gameObject.transform;
    }

    void Update()
    {
        //Debug.Log("5" + gameObject.transform.position);
        // Fare týklamasýný kontrol edin
        if (Input.GetMouseButtonDown(0))
        {
            
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            
            MoveTowards(targetPosition);
        }
        posX = Random.Range(-6.5f, 6.5f);
        posY = Random.Range(-3.5f, 3.5f);

        spawnPoint.position = new Vector3(posX, posY, 0);
        if (!olusturdu)
            StartCoroutine(bekle());
    }

    
    void MoveTowards(Vector3 target)
    {      
        Vector2 direction = (target - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("robot"))
        {
            Destroy(collision.gameObject);
            SkorGuncelle();
        }
    }

    private void SkorGuncelle()
    {
        
        toplamSkor++;
        skor.text = "" + toplamSkor;
    }

    IEnumerator bekle()
    {
        olusturdu = true;
        yield return new WaitForSeconds(bekleSure);
        Instantiate(cop, spawnPoint.position, Quaternion.identity);
        olusturdu = false;
    }
}
