using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody rb;//reference to rigidbody
    // Start is called before the first frame update
    
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // Update is called once per frame

    void FixedUpdate()//to mess with physics
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);//Add a forward force on the z-axis

        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
            
        }
           if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
            
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
