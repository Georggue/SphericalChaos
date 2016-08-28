using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float MoveSpeed = 15f;
    private Vector3 moveDir;
    public KeyCode KeyLeft;
    public KeyCode KeyRight;
    void Update()
    {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        //var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //Quaternion wanted_rotation = Quaternion.LookRotation(moveDir);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, wanted_rotation, 200 * Time.deltaTime);
     
        //transform.Translate(0, 0, z);
        if (!Input.GetKeyDown(KeyLeft) && !Input.GetKeyDown(KeyRight))
        {
            var rb = GetComponent<Rigidbody>().constraints == RigidbodyConstraints.FreezeRotation;
        }
        else
        {
            var rb = GetComponent<Rigidbody>().constraints == (RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ);
        }
    }

    void FixedUpdate()
    {
        var rb = GetComponent<Rigidbody>();
        rb.MovePosition(rb.position + transform.TransformDirection(moveDir) *MoveSpeed * Time.deltaTime);
    }
}