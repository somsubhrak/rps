using UnityEngine;

public class playerMovement : MonoBehaviour
{
   // Start is called once before the first execution of Update after the MonoBehaviour is created
   public float moveSpeed = 2.0f;
   private Rigidbody2D rb;
   private Vector2 movement;
   void Start()
   {
      rb = GetComponent<Rigidbody2D>();
   }

   // Update is called once per frame
   void Update()
   {
      movement.x = Input.GetAxis("Horizontal");
      movement.y = Input.GetAxis("Vertical");
   }
   void FixedUpdate()
   {
      rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
   }
}