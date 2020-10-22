using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityHandler : MonoBehaviour
{
	public GameObject player;
	
	public void Slider(Slider vol){
		Debug.Log ( "vol is: " + vol );
	}
}
