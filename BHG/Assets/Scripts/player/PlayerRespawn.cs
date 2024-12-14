using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    //skrytp ze zmiana czasu
    //skrypt do smierci
    private GameObject player;
    [SerializeField] private CheckpointHandlerScript checkpointHandler;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void respawnOnLastCheckpoint()
    {
        player.transform.position = checkpointHandler.lastCheckpoint; // dodanie respa w zaleznosci od swiata w ktorym sie znajdujemy
    }
    
   
}
