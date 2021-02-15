using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    // this is a reference to the Rigidbody component called "rb"
    public Rigidbody rig;
    public Transform rigTransform;

    public float moveSpeed;
    public Toggle Controller;
    public Text controllerEnabled;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

	// We marked this as "fixed"update because we
    // are using it to mess with physics.
	void FixedUpdate ()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add a forward force

        if(Input.GetKey("d"))
        {
            rig.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rig.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("s"))
        {
            rig.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rig.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Controller.isOn == true)
        {
            Move();
            controllerEnabled.text = "Non-Kinematic Controller Enabled";
        }
        else 
        {
            FixedUpdate();
            controllerEnabled.text = "Kinematic Controller Enabled";
        }
    }

    void Move()
    {
        // get the horizontal and vertical inputs
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // apply that to our velocity
        rig.velocity = new Vector3(x, 0, z) * moveSpeed;
    }
}
