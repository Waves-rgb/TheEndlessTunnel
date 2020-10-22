﻿using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
 using UnityEngine.UI;

 public class MenuHandler : MonoBehaviour
{
	public GameObject player;
	public GameObject playerCamera;
	public GameObject text;
	public GameObject canvas;
	public GameObject SensSlider;

	private bool isShowing = true;

	void Start()
	{
		player.GetComponentInChildren<PlayerCamera>().menuopen = true;
		text.GetComponent<UnityEngine.UI.Text>().text = "Sensitivity - " + player.GetComponentInChildren<PlayerCamera>().sens.ToString();
		SensSlider.GetComponent<Slider>().value = playerCamera.GetComponent<PlayerCamera>().sens;

	}

	void Update()
	{
		if (player.GetComponentInChildren<PlayerCamera>().sens != SensSlider.GetComponent<Slider>().value)
		{
			text.GetComponent<UnityEngine.UI.Text>().text = "Sensitivity - " + Math.Round(player.GetComponentInChildren<PlayerCamera>().sens / 10).ToString();
			playerCamera.GetComponent<PlayerCamera>().sens = SensSlider.GetComponent<Slider>().value;
		}
		if (Input.GetKeyDown("escape"))
		{
			isShowing = !isShowing;
			playerCamera.GetComponent<PlayerCamera>().menuopen = isShowing;
			canvas.SetActive(isShowing);
		}
	}

	void BroadcastMessage(String s)
	{
		if (s == "resume")
		{
			isShowing = false;
			playerCamera.GetComponent<PlayerCamera>().menuopen = isShowing;
			canvas.SetActive(isShowing);
		}

		if (s == "quit")
		{
			Application.Quit();
		}
	}
}
