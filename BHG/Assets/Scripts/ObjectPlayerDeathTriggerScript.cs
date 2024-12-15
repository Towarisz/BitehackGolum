using System;
using UnityEngine;

public class ObjectPlayerDeathTriggerScript : MonoBehaviour
{
   [SerializeField] private GameObject deathScreen;

   private void OnTriggerEnter2D(Collider2D other)
   {
       if (other.CompareTag("Player") && !deathScreen.activeSelf)
       {
           deathScreen.SetActive(true);
       }
   }
}
