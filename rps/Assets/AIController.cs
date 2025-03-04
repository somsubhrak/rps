using UnityEngine;

public class AIController : MonoBehaviour
{
   // Start is called once before the first execution of Update after the MonoBehaviour is created
   float speed = 5f;
   private Transform target;
   // Update is called once per frame
   void Update()
   {
      if (target != null)
      {
         Debug.Log("AI moving towards: " + target.name);
         transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
      }
      else
      {
         GameObject unit=GameObject.FindGameObjectWithTag("Player");
         target = unit.transform;
      }
   }
   public void setTarget(Transform newTarget)
   {
      target=newTarget;
   }
}
