using UnityEngine;
using System.Collections;

public class Comunicate : MonoBehaviour {
	
	void OnMouseDown()
    {
        GameObject Controller = GameObject.Find("Controller");
        LinkObjects LinkCubeScript = Controller.GetComponent<LinkObjects>();

        if (LinkCubeScript.m_FirstSlot == null)
        {
            LinkCubeScript.m_FirstSlot = gameObject;
        }
        else if (LinkCubeScript.m_SecondSlot == null && gameObject.name != LinkCubeScript.m_FirstSlot.name)
        {
            if(LinkCubeScript.m_FirstSlot != gameObject)
            {
                LinkCubeScript.m_SecondSlot = gameObject;
            }
        }
    }
    
    public void DestroyThisObject()
    {
        Destroy(gameObject, 0);
    }

}
