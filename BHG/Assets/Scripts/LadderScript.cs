using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class LadderScript : MonoBehaviour
{
    private PlayerMovement player;

    private void Awake()
    {
        player = Object.FindFirstObjectByType<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Player"))
        {
            player.OnLadder = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !player.OnLadder)
        {
            player.OnLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.OnLadder = false;
        }
    }
}
