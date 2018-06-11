﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeBase : MonoBehaviour {

	public GameObject classicalOne;
	public GameObject classicalZero;
	public GameObject classicalBitArrow; 

	public GameObject circleX;
	public GameObject circleY;
	public GameObject circleZ;
	public GameObject quantumBitOne;
	public GameObject quantumBitZero;
	public GameObject quantumBitArrow;

	public Button switchToClassicalBit;
	public Button switchToQuantumBit;

	public Slider thetaSlider;
	public Slider phiSlider;
	// Use this for initialization
	void Start () {
		enableQuantumBit ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void enableClassicalBit(){
		disableQuantumBit ();

		classicalOne.SetActive (true);
		classicalZero.SetActive (true);
		classicalBitArrow.SetActive(true);

		thetaSlider.maxValue = 1;
		phiSlider.interactable = false;

		switchToClassicalBit.GetComponent<Image>().color = Color.yellow; 
	}

	public void enableQuantumBit(){
		disableClassicalBit();

		circleX.SetActive(true);
		circleY.SetActive(true);
		circleZ.SetActive(true);
		quantumBitOne.SetActive(true);
		quantumBitZero.SetActive(true);
		quantumBitArrow.SetActive(true);

		thetaSlider.maxValue = 180;
		phiSlider.interactable = true;

		switchToQuantumBit.GetComponent<Image>().color = Color.yellow; 
	}

	public void disableClassicalBit(){

		classicalOne.SetActive (false);
		classicalZero.SetActive (false);
		classicalBitArrow.SetActive(false);

		switchToClassicalBit.GetComponent<Image>().color = Color.white; 
	}

	public void disableQuantumBit(){
		circleX.SetActive(false);
		circleY.SetActive(false);
		circleZ.SetActive(false);
		quantumBitOne.SetActive(false);
		quantumBitZero.SetActive(false);
		quantumBitArrow.SetActive(false);

		switchToQuantumBit.GetComponent<Image>().color = Color.white;
	}
}
