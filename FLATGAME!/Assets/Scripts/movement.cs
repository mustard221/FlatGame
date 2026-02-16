using UnityEngine;

public class movement : MonoBehaviour
{
    void Start()
    {
        float hInput = Input.GetAxis("Horizontal"); // get player input
        float vInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        //applying input to movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 10);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 10);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 10);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 10);
        }
    }
}
