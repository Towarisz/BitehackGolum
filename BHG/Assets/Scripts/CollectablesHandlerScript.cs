using UnityEngine;

public class CollectablesHandlerScript : MonoBehaviour
{
    public int collectablesCount { get;private set; }

    void Start()
    {
        collectablesCount = 0;
    }

    public void AddCollectable()
    {
        collectablesCount++;
    }
}
