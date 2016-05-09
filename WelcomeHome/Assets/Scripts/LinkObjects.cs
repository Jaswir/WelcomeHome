using UnityEngine;
using System.Collections;

public class LinkObjects : MonoBehaviour {

    [SerializeField]
    public GameObject m_FirstSlot;
    [SerializeField]
    public GameObject m_SecondSlot;
    [SerializeField]
    private GameObject[] m_AllInteractableObjects = new GameObject[3];

	void Start()
    {
        for (int i = 0; i < m_AllInteractableObjects.Length; i++)
        {
            m_AllInteractableObjects[i] = GameObject.Find("Cube" + i);
        }
	}
	

	void LateUpdate()
    {
        if (m_FirstSlot != null && m_SecondSlot == null)
        {
            Debug.DrawLine(m_FirstSlot.transform.position, Camera.main.ScreenToViewportPoint(Input.mousePosition));
        }
        else if (m_FirstSlot != null && m_SecondSlot != null)
        {
            Instantiate(Resources.Load<GameObject>("PreFabs/MarbleLane"), new Vector3(m_FirstSlot.transform.position.x, m_FirstSlot.transform.position.y + 2, m_FirstSlot.transform.position.z - 2), Quaternion.identity);
            Comunicate communicatescript1 = m_FirstSlot.GetComponent<Comunicate>();
            Comunicate communicatescript2 = m_SecondSlot.GetComponent<Comunicate>();
            m_FirstSlot = null;
            m_SecondSlot = null;

            communicatescript2.DestroyThisObject();
            communicatescript1.DestroyThisObject();

            Debug.Log("TEST");
        }
    }
}
