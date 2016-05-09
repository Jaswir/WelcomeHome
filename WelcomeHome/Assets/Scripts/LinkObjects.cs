using UnityEngine;
using System.Collections;

public class LinkObjects : MonoBehaviour {

    [SerializeField]
    private GameObject m_FirstSlot;
    [SerializeField]
    private GameObject m_SecondSlot;
    [SerializeField]
    private GameObject[] m_AllInteractableObjects = new GameObject[3];

	void Start()
    {
        for (int i = 0; i < m_AllInteractableObjects.Length; i++)
        {
            m_AllInteractableObjects[i] = GameObject.Find("Cube" + i);
        }
	}
	

	void OnClick()
    {
	
	}
}
