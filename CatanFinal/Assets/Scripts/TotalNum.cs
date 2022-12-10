using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TotalNum : MonoBehaviour
{
	public DiceOne diceValueOne;

	public DiceTwo diceValueTwo;

	public int totalValue;

	private void Start()
    {
		diceValueOne = FindObjectOfType<DiceOne>();
		diceValueTwo = FindObjectOfType<DiceTwo>();		
	}   

    public void OnClick()    {
		
		int number1 = diceValueOne.diceValue;
		int number2 = diceValueTwo.diceValue;
		totalValue = number1 + number2;

		//new WaitForSeconds(0.5f);	

		Debug.Log(totalValue);

	}
}
