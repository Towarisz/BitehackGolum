using System;
using UnityEngine;

public class ObjectPlayerDeathTriggerScript : MonoBehaviour
{
    private GameObject deathScreen;

   private void Awake()
   {
       deathScreen = GameObject.FindGameObjectWithTag("DeathScreen");
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
       if (other.CompareTag("Player") && !deathScreen.activeSelf)
       {
           deathScreen.SetActive(true);
       }
   }
}
