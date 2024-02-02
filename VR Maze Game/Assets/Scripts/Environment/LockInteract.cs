using UnityEngine;
using UnityEngine.Events;

public class LockInteract : MonoBehaviour
{
	// Public variables
	[SerializeField] UnityEvent unlocked;
	public GameObject key;
	public bool removeLock = true;
	public bool isLocked = true;

	// On collision
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject == key && isLocked == true)
		{
			isLocked = false;
			unlocked.Invoke();
			if (removeLock)
			{
				GetComponent<MeshRenderer>().enabled = false;
			}
		}
	}
}
