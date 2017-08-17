using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Text displaytext;
	public Button HigherButton;
	public Button LowerButton;
	public Button YesButton;
	int RandomNumber;
	int PickedNumber;
	int ResultNumber = 2;//higher = 1, lower = -1, yes = 0

	// Use this for initialization
	void Start () {
		RandomNumber = Random.Range (0, 100);
		PickedNumber = RandomNumber;
		displaytext.text = "Is " + RandomNumber + " is the number in your mind ? .-.";
		NumberRangeChanger ();
	}
	public void higherbutton()
	{
		ResultNumber = 1;
			NumberRangeChanger();
		
	}
	public void lowerbutton()
	{
		ResultNumber = -1;
			NumberRangeChanger();

	}
	public void yesbutton(){
		ResultNumber = 0;
			displaytext.text ="The computer won .-.";
	}

	public void NumberRangeChanger()
	{
		if (ResultNumber == 1) {
			RandomNumber = Random.Range (PickedNumber, 100);
			PickedNumber = RandomNumber;
			displaytext.text = "Is " + RandomNumber + " is the number in your mind ? .-.";
		} else if (ResultNumber == -1) {
			RandomNumber = Random.Range (0, PickedNumber);
			PickedNumber = RandomNumber;
			displaytext.text = "Is " + RandomNumber + " is the number in your mind ? .-.";
		} else if (ResultNumber == 0) {
			print ("The computer won !!! :<");
			
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
