using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePotion : MonoBehaviour
{
    private Outline _outline;
    private void Start()
    {
        _outline = GetComponent<Outline>();
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Potion")
        {
            _outline.OutlineWidth = 2;
            Destroy(other.gameObject);
        }
	}
}
