using UnityEngine;
using System.Collections;

public class TestingBallBehaviour : MonoBehaviour {

    public float force;
    private float counter = 5;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            force = counter + counter / Time.deltaTime;
        }

	
	}

    void OnTriggerStay ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            transform.rotation = Quaternion.identity;
            GetComponent<Rigidbody>().AddForce(transform.forward * force);
        }
    }
}
