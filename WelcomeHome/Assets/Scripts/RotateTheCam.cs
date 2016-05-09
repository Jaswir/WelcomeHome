using UnityEngine;
using System.Collections;

public class RotateTheCam : MonoBehaviour {
	

	void Update()
    {
        Vector3 Rotation = new Vector3(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0);

        //Rotation.x = Mathf.Clamp(Rotation.y, -44.89f, 50);

        transform.Rotate(Rotation);
	}
}
