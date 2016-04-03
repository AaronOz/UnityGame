using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class MobaMovement : MonoBehaviour{

	private NavMeshAgent navMeshAgent;
	public const string ANIM_WALK = "walk";

	Animator anim;
	// Use this for initialization
	void Awake ()
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Input.GetButtonDown ("Fire2")) {
			anim.SetBool ("walk", true);
			if (Physics.Raycast (ray, out hit, 100)) {


				//mueve al personaje al punto que fue dado click
				navMeshAgent.destination = hit.point;
				navMeshAgent.Resume ();


				if(hit.collider.CompareTag("Enemy")) {
					//Hit a un enemigo
					Debug.Log("hit");
				}

			}

		}
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			
		}
	}

}

