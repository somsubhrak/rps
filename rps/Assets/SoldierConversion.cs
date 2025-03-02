using UnityEngine;

public class SoldierConversion : MonoBehaviour
{
   public string soldierType; // Rock, Paper, or Scissors
   public Sprite rockSprite, paperSprite, scissorsSprite;

   void Start()
   {
      // Set initial type based on tag
      soldierType = gameObject.tag;
   }

   void OnTriggerEnter2D(Collider2D other)
   {
      SoldierConversion otherSoldier = other.GetComponent<SoldierConversion>();
      if (otherSoldier != null)
      {
         ConvertIfWeaker(otherSoldier);
      }
   }

   void ConvertIfWeaker(SoldierConversion other)
   {
      if ((soldierType == "Rock" && other.soldierType == "Scissors") ||
          (soldierType == "Scissors" && other.soldierType == "Paper") ||
          (soldierType == "Paper" && other.soldierType == "Rock"))
      {
         // Convert the weaker soldier to the attacker's type
         other.ChangeType(soldierType);
      }
   }

   public void ChangeType(string newType)
   {
      soldierType = newType;
      gameObject.tag = newType;

      // Change sprite based on type
      SpriteRenderer sr = GetComponent<SpriteRenderer>();
      if (newType == "Rock") sr.sprite = rockSprite;
      else if (newType == "Paper") sr.sprite = paperSprite;
      else if (newType == "Scissors") sr.sprite = scissorsSprite;
   }
}
