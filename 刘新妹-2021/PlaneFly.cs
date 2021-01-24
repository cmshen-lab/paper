using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFly : MonoBehaviour {
    public float forward_speed = 13.0f;
    public float back_speed = 8.0f;
    public float rotation_speed = 100;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * forward_speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.forward * back_speed * -1 * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(this.transform.up * rotation_speed * -1 * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(this.transform.up * rotation_speed * Time.deltaTime);

        }
    }
}
