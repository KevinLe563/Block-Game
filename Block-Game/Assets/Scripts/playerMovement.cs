using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 4000f;
    public float sidewaysForce = 100f;
    // Start is called before the first frame update

    // FixedUpdate used to change the physics
    void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("a")) {
            rb.AddForce(sidewaysForce * -1  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
