using UnityEngine;
using System.Collections;

public class FollowTheMouse : MonoBehaviour {

    public Vector3 temp;

    void Start()
    {
        temp = new Vector3(2, 2, 2);
    }

	void Update()
    {
        print(Input.GetAxis("Mouse ScrollWheel"));
	}
	

	void OnMouseDrag()
    {
        temp = new Vector3(Input.mousePosition.x, Input.mousePosition.y, temp.z);

        if(temp.z < 2)
        {
            temp.z = 2;
        }

        temp.z += Input.GetAxis("Mouse ScrollWheel"); // Set this to be the distance you want the object to be placed in front of the camera.

        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}
