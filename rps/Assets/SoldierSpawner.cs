using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawner : MonoBehaviour
{
   public GameObject soldierPrefab; // Assigned in Inspector
   public float spawnInterval = 2.5f; // Time between spawns
   public float spawnDistance = 1f; // Distance behind the player
   private float timer = 0f;

   private List<GameObject> spawnedSoldiers = new List<GameObject>();

   void Update()
   {
      timer += Time.deltaTime;
      if (timer >= spawnInterval)
      {
         SpawnSoldier();
         timer = 0f;
      }
   }

   void SpawnSoldier()
   {
      Vector3 spawnPos = transform.position - transform.up * spawnDistance;
      GameObject newSoldier = Instantiate(soldierPrefab, spawnPos, Quaternion.identity);
      spawnedSoldiers.Add(newSoldier);
   }
}
