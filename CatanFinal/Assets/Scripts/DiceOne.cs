using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceOne : MonoBehaviour
{
    // Array of dice sides sprites to load from Resources folder
    public Sprite[] diceSides;
    public Image original;

    // Reference to sprite renderer to change sprites
    public SpriteRenderer rend;    

    // Show one dice result
    public int diceValue;

    //public GameObject BankArea;
    //public GameObject Dice1;

    //public static List<int> diceValues = new List<int>();


    void Start()
    {
        // Assign Sprite Renderer component
        rend = GetComponent<SpriteRenderer>();
        
        // Load dice sides sprited to array from Dice Sides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        //Dice1.transform.SetParent(BankArea.transform, false);

    }
    public void changeSides()
    {
        // Coroutine that rolls the dice        
        //Debug.Log("Clicked");
        StartCoroutine("RollTheDice");

    }
    public IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially 
        int randomDiceSide = 0;

        // Find side or value that dice reads in the end of coroutine
        int finalSide = 0;

        // Loop to switch dice sides randomly
        // Before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 5);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide];
            original.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // For player movement for example
        finalSide = randomDiceSide + 1;

        diceValue = finalSide;

        //diceValues.Add(diceValue);

        // Show final dice value in Console
        Debug.Log(finalSide);
        
    }
}
