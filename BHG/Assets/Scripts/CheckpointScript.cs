using UnityEngine;


public class checkpointScript : MonoBehaviour
{
    private CheckpointHandlerScript checkpointHandler;

    private void Start()
    {
        checkpointHandler = Object.FindFirstObjectByType<CheckpointHandlerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag( "Player") && checkpointHandler.lastCheckpoint != (Vector2)transform.position)
        {
            checkpointHandler.setCheckpoint(transform.position);
            
            Object.Destroy(this);
        }
    }
}
