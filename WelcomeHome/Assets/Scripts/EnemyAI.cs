using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    GameObject treasure;
    public float speed;

	// Use this for initialization
	void Start () {
        //Find Treasure object
        treasure = GameObject.FindGameObjectWithTag("Treasure");
	
	}

    // Update is called once per frame
    void Update()
    {
        //Match Direction and Align with treasure
        Vector3 dir = treasure.transform.position - gameObject.transform.position;
        Vector3 rotation = gameObject.transform.localRotation.eulerAngles - treasure.transform.localRotation.eulerAngles;

        Enemy EnemyScript = gameObject.GetComponent<Enemy>();
        EnemyScript.m_EnemyState = enemyState.Walking;
        gameObject.transform.position += dir * speed;
       // gameObject.transform.rotation = Quaternion.Euler(rotation);


    }
}
