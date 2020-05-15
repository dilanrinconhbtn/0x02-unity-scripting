using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 1000f;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    // fixed beacuse includes physiscs  
    void FixedUpdate()
    {
        if( Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if( Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if( Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if( Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        score++;
    }
}
