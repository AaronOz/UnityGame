using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class MobaMovement : MonoBehaviour
{
	private NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Awake ()
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Input.GetButtonDown ("Fire2")) {
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
	}

}

