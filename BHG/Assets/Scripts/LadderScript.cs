using UnityEngine;

public class LadderScript : MonoBehaviour
{
    [SerializeField] PlayerMovement player;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Player"))
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
