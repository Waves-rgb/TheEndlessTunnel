using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class Portal : MonoBehaviour
{

	public GameObject player;

	public Transform otherPortal;

	public bool IsPortalOne = false;
	
	void OnTriggerEnter(Collider other)
	{

		if (IsPortalOne)
		{
			player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, otherPortal.position.z - 2f);
		}
		else
		{
			player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, otherPortal.position.z + 2f);
		}
	}
}