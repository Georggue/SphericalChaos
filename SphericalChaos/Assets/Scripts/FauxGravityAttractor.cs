using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour
{
    public float Gravity = -10f;

    public void Attract(Transform body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;

        body.GetComponent<Rigidbody>().AddForce(gravityUp * Gravity);
        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50 * Time.deltaTime);
    }


    //everything within this radius is pulled towards the center at a constant rate in all areas
    public float GravityRadius;

    //gravityRadius will fade out to zero pull by the time it reaches this radius ( make bigger than gravityRadius)
    public float GravityRadiusFade;

    //makes the gravityRadius's proportionate to the objects scale
    public bool RadiiProportionateToScale = true;

    //controls ratio of gravityRadius var to the objects scale
    public float RadiusProportion = .75f;

    //controls ratio of gravityRadiusFade var to the objects scale
    public float RadiusFadeProportion = 1.5f;

   


    void OnDrawGizmos()
    {

        if (RadiiProportionateToScale)
        {
            GravityRadius = transform.localScale.x * RadiusProportion;
            GravityRadiusFade = transform.localScale.x * RadiusFadeProportion;
        }

        Gizmos.color = Color.white;

        Gizmos.DrawWireSphere(transform.position, GravityRadius);
        Gizmos.DrawWireSphere(transform.position, GravityRadiusFade);
    }
}
