using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{

			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out RaycastHit info))// && info.collider.gameObject.layer
				//== LayerMask.NameToLayer("Clickable"))
			{
				_destination = info.point;
			}

		}
		// Перемещаем персонажа в направлении _destination.
		_navMeshAgent.SetDestination(_destination);

		// TODO: Получите точку, по которой кликнули мышью и задайте ее вектор в поле _destination.
		
	}

	
}