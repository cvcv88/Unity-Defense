using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Monster : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;

    public UnityEvent OnEndPointArrived;

	private void Update()
	{
		CheckEndPoint();
	}
	public void SetDestination(Vector3 destination)
    {
        agent.destination = destination;
    }

    private void CheckEndPoint()
    {
        // if(agent.remainingDistance < 0.01f)
        if ((transform.position - agent.destination).sqrMagnitude < 0.01f)
        {
            Debug.Log("���Ͱ� �������� ������ �߽��ϴ�~");
			OnEndPointArrived?.Invoke();
            Destroy(gameObject);
        }
    }
}
