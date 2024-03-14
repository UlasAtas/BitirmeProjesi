using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Karakterin hareket hýzý

    private Rigidbody2D rb; // Karakterin Rigidbody bileþeni

    void Start()
    {
        // Rigidbody bileþenine eriþin
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Fare týklamasýný kontrol edin
        if (Input.GetMouseButtonDown(0))
        {
            // Týklanan noktanýn dünya koordinatlarýný alýn
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0f; // Z eksenini sýfýrlayýn

            // Karakterin hedefe doðru hareket etmesini saðlayýn
            MoveTowards(targetPosition);
        }
    }

    // Karakteri hedefe doðru hareket ettiren metod
    void MoveTowards(Vector3 target)
    {
        // Hedefe doðru bir vektör oluþturun ve normalleþtirin
        Vector2 direction = (target - transform.position).normalized;

        // Karakterin hareket etmesini saðlayýn
        rb.velocity = direction * moveSpeed;
    }
}
