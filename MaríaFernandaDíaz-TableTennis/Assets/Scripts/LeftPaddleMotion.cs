using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.back * 0.1f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.up * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.forward * 0.1f);
        }
    }
}
