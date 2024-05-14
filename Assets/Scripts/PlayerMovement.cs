using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    //public Touch t;
    public Vector2 target;
    public bool move = false;
    float epsilon = 0.05f;

    void Update()
    {
        Debug.Log(rb.position);

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            if (!(firstPressPos.x > 420 && firstPressPos.x < 1490 && firstPressPos.y > 0 && firstPressPos.y < 210))
            {
                Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                targetPosition.x = Mathf.Round(targetPosition.x * 100f) / 100f;
                targetPosition.y = Mathf.Round(targetPosition.y * 100f) / 100f;
                target = targetPosition;
                move = true;
            }
        }

        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            Vector2 firstPressPos = new Vector2(t.position.x, t.position.y);

            if (!(firstPressPos.x > 420 && firstPressPos.x < 1490 && firstPressPos.y > 0 && firstPressPos.y < 210))
            {
                Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                targetPosition.x = Mathf.Round(targetPosition.x * 100f) / 100f;
                targetPosition.y = Mathf.Round(targetPosition.y * 100f) / 100f;
                target = targetPosition;
                move = true;
            }
        }

        if (move)
        {
            // Check X direction
            if (Mathf.Abs(rb.position.x - target.x) < epsilon)
            {
                movement.x = 0;
            }
            else if (rb.position.x < target.x)
            {
                movement.x = 1;
            }
            else
            {
                movement.x = -1;
            }

            // Check Y direction
            if (Mathf.Abs(rb.position.y - target.y) < epsilon)
            {
                movement.y = 0;
            }
            else if (rb.position.y < target.y)
            {
                movement.y = 1;
            }
            else
            {
                movement.y = -1;
            }

            // Stop moving if close enough to the target
            if (Vector2.Distance(rb.position, target) < 0.1f)
            {
                move = false;
                movement = Vector2.zero; // Ensure movement stops completely
            }
        }

        if (movement.x != 0)
        {
            animator.SetFloat("Horizontal", movement.x);
        }

        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
