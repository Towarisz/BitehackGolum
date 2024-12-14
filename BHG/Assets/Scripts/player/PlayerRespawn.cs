using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private GameObject player;
    [SerializeField] private CheckpointHandlerScript checkpointHandler;
    public void respawnOnLastCheckpoint()
    {
        player.transform.position = checkpointHandler.lastCheckpoint + new Vector2(0,playerMovement.currentTimeline * playerMovement.gapBetweenTimelines);
    }
    
   
}
