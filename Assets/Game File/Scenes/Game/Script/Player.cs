using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var direction = new Vector2();
        if (Input.GetKey("w"))
        {
            direction.y = 1;
        }
        if (Input.GetKey("s"))
        {
            direction.y = -1;
        } 
        if (Input.GetKey("d"))
        {
            direction.x = 1;
        } 
        if (Input.GetKey("a"))
        {
            direction.x = -1;
        } 
        if (!Input.GetKey("a") && !Input.GetKey("d") && !Input.GetKey("s") && !Input.GetKey("w")) {
            _rb.velocity = _rb.velocity/1.05f;
        }

        _rb.AddForce(direction.normalized * 5);
    }
}
