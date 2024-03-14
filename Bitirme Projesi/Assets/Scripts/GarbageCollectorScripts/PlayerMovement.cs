using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Karakterin hareket h�z�

    private Rigidbody2D rb; // Karakterin Rigidbody bile�eni

    void Start()
    {
        // Rigidbody bile�enine eri�in
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Fare t�klamas�n� kontrol edin
        if (Input.GetMouseButtonDown(0))
        {
            // T�klanan noktan�n d�nya koordinatlar�n� al�n
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0f; // Z eksenini s�f�rlay�n

            // Karakterin hedefe do�ru hareket etmesini sa�lay�n
            MoveTowards(targetPosition);
        }
    }

    // Karakteri hedefe do�ru hareket ettiren metod
    void MoveTowards(Vector3 target)
    {
        // Hedefe do�ru bir vekt�r olu�turun ve normalle�tirin
        Vector2 direction = (target - transform.position).normalized;

        // Karakterin hareket etmesini sa�lay�n
        rb.velocity = direction * moveSpeed;
    }
}
