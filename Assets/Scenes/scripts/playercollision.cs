using UnityEngine;

public class playercollision : MonoBehaviour
{
    public player_movement movement;
   
    void OnCollisionEnter(Collision collisionInfo)
    {
       if(collisionInfo.collider.tag == "obstacle")
       {
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();

       }
    }
}
