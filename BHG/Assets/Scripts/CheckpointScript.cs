using UnityEngine;

public class checkpointScript : MonoBehaviour
{
    
    [SerializeField] private CheckpointHandlerScript checkpointHandler;

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag( "Player"))
        {
            checkpointHandler.setCheckpoint(transform.position);
            Object.Destroy(this);
        }
    }
}
