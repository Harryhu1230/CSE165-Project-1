using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Dummy_NM")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
