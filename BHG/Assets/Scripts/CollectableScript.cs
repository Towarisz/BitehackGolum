using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    private CollectablesHandlerScript collectablesHandler;
    private void Start()
    {
        collectablesHandler = Object.FindFirstObjectByType<CollectablesHandlerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            collectablesHandler.AddCollectable();
            Object.Destroy(this.gameObject);
        }
    }
}
