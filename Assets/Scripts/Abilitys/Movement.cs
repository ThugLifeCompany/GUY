using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour, IMove
{
	public void Move(Transform target)
	{
		GetComponent<NavMeshAgent>().SetDestination(target.position);
	}
}
