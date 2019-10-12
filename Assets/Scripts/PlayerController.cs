using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movement = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement += new Vector3(-2, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement += new Vector3(0, 0, -2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement += new Vector3(2, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement += new Vector3(0, 0, 2);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement.Scale(new Vector3(18, 0, 10));
        }

        this.GetComponent<Rigidbody>().AddForce(movement, ForceMode.Impulse);
    }
}
