using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class PlayerRespawn : MonoBehaviour
{
    private PlayerMovement playerMovement;
    [SerializeField] private GameObject player;
    private CheckpointHandlerScript checkpointHandler;
    private CollectablesHandlerScript collectablesHandler;

    private void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
        checkpointHandler = Object.FindFirstObjectByType<CheckpointHandlerScript>();
        collectablesHandler = Object.FindFirstObjectByType<CollectablesHandlerScript>();
    }

    public void Respawn()
    {
        respawnOnLastCheckpoint();
        resetCollcetablesCount();
    }
    void respawnOnLastCheckpoint()
    {
        player.transform.position = checkpointHandler.lastCheckpoint + new Vector2(0,playerMovement.currentTimeline * playerMovement.gapBetweenTimelines);
    }

    void resetCollcetablesCount()
    {
        //collectablesHandler.setCollectablesCount(checkpointHandler.lastCollectablesCount);
    }
   
}
