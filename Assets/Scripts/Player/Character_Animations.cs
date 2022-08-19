using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_Animations : MonoBehaviour 
{
	private Animator animator;
	private float v,h;
	private int run = 2;

	void Start () 
	{
		animator = GetComponent <Animator>();
	}
	
	void Update () 
	{
		v=Input.GetAxis("Vertical");
		h=Input.GetAxis("Horizontal");
	}

	void FixedUpdate ()
	{
			animator.SetFloat("Walk",v);
			animator.SetFloat("Run",run);
			animator.SetFloat("Turn",h);
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
			SceneManager.LoadScene(1);
        }

		if(other.tag == "NextLevel")
        {
			SceneManager.LoadScene(2);
        }
    }
}