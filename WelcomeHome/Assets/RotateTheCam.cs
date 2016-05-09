using UnityEngine;
using System.Collections;

public class RotateTheCam : MonoBehaviour {
	

	void Update()
    {
        transform.Rotate(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0);
	}
}
