using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour
{

    public FauxGravityAttractor Attractor;
    private Transform myTransform;
    // Use this for initialization
    void Start()
    {
        var rigidbody = GetComponent<Rigidbody>();
       
        rigidbody.useGravity = false;

        myTransform = transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Attractor)
        {
            Attractor.Attract(myTransform);
        }
       
    }

    //public FauxGravityAttractor[] attractor;
    //public Rigidbody Rigidbody;
    //// are we touching the surface?
    //public int grounded;
    //public bool SnapYAxisToGravity = false;
    //bool attract = true;

    //void Start()
    //{
    //    Rigidbody.WakeUp();
    //    Rigidbody.useGravity = false;
    //}

    //// obviously this is crude since we might want to be able to stand on (and jump off) random objects
    //// should probably filter based on tag in future
    //void OnCollisionEnter(Collision c)
    //{
    //    if (c.gameObject.layer == 10)
    //    {
    //        grounded++;
    //    }
    //}

    //void OnCollisionExit(Collision c)
    //{
    //    if (c.gameObject.layer == 10 && grounded > 0)
    //    {
    //        grounded--;
    //    }
    //}

    //void FixedUpdate()
    //{

    //    if (attract)
    //    {
    //        for (int i = 0; i < attractor.Length; i++)
    //        {

    //            if (attractor[i])
    //            {
    //                attractor[i].Attract(this);
    //            }
    //        }
    //    }

    //}


}
