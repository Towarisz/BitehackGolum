using UnityEngine;

public class CheckpointHandlerScript : MonoBehaviour
{
    public Vector2 lastCheckpoint { get; private set; }
    public int lastCollectablesCount { get; private set; }
    

    public void setCheckpoint(Vector2 point)
    {
        Debug.Log("Checkpoint set to -> "+point);
        lastCheckpoint = point;
    }

    public void setCollectablesCount(int Count)
    {
        lastCollectablesCount = Count;
    }
}
