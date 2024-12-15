using UnityEngine;


public class checkpointScript : MonoBehaviour
{
    private CheckpointHandlerScript checkpointHandler;
    private PlayerMovement playerMovement;

    private void Start()
    {
        checkpointHandler = Object.FindFirstObjectByType<CheckpointHandlerScript>();
        playerMovement = Object.FindFirstObjectByType<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag( "Player") && checkpointHandler.lastCheckpoint != (Vector2)transform.position)
        {
            checkpointHandler.setCheckpoint(transform.position - new Vector3(0,-playerMovement.currentTimeline*playerMovement.gapBetweenTimelines,0f));
            
            Object.Destroy(this);
        }
    }
}
