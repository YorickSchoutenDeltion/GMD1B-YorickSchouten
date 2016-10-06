using UnityEngine;
using System.Collections;

public class TestingBallBehaviour : MonoBehaviour {

    public float currentForce;
    private float counter = 5;
    public float maximumForce = 5;
    public float timer;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            if (currentForce < maximumForce)
            {
                timer += Time.deltaTime;
                if (timer > 1.0f)
                {
                    currentForce += 1;
                    timer -= 1.0f;
                }
            }
        }

	
	}

    void OnTriggerStay ()
    {
        if (Input.GetButtonUp("Jump"))
        {
            transform.rotation = Quaternion.identity;
            GetComponent<Rigidbody>().AddForce(transform.forward * currentForce * 800);
            currentForce = 0;
        }
    }
}
