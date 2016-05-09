using UnityEngine;
using System.Collections;

public enum enemyState {
    Idle = 0,
    Walking
}


public class Enemy : MonoBehaviour {

    [SerializeField]
    private Animator m_Animator;
    public enemyState m_EnemyState = 0;

	// Use this for initialization
	void Start ()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        m_Animator.SetInteger("EnemyState", (int)m_EnemyState);

    }
}
