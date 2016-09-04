using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class BulletScript : MonoBehaviour
{
    [Range(0,20)]
    public int LifeTime = 6;
	// Use this for initialization
    private Stopwatch StopWatch;
	void Start () {
	    StopWatch = new Stopwatch();
        StopWatch.Start();
      
    }

    // Update is called once per frame
    void Update () {
	    if (StopWatch.ElapsedMilliseconds >= LifeTime*1000)
	    {
            UnityEngine.Debug.Log("Die");
	        Destroy(this.gameObject);
	    }
      //  GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 10), ForceMode.Force);
    }

    void OnCollisionEnter(Collision col)
    {
     //  Destroy(this.gameObject);        
    }
}
