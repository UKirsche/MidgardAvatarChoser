using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCharacterChosen : MonoBehaviour {

	enum CharacterTypen{
		Harold,Kim, Shelly,Sven, Troll
	}

	public Slider slider;
	private UMACharacterChoser umaChoser;
	private string characterNameChosen;


	void Start(){

		//Lade UMA-Creator-Skript
		umaChoser = GameObject.FindObjectOfType<UMACharacterChoser> ();
	}

	#region Lade UMSAsset
	public void LoadUMAfromSliderValue()
	{
		int sliderValue = Convert.ToInt32(slider.value);

		if (sliderValue == (int) CharacterTypen.Harold + 1) {
			umaChoser.LoadUMAAsset (CharacterTypen.Harold.ToString());
		} else if (sliderValue==(int) CharacterTypen.Kim + 1) {
			characterNameChosen = CharacterTypen.Kim.ToString ();
			umaChoser.LoadUMAAsset (CharacterTypen.Kim.ToString());
		} else if (sliderValue==(int) CharacterTypen.Shelly + 1) {
			umaChoser.LoadUMAAsset (CharacterTypen.Shelly.ToString());
		} else if (sliderValue==(int) CharacterTypen.Sven + 1) {
			umaChoser.LoadUMAAsset (CharacterTypen.Sven.ToString());
		} else if (sliderValue==(int) CharacterTypen.Troll + 1) {
			umaChoser.LoadUMAAsset (CharacterTypen.Troll.ToString());
		}

	}
	#endregion


	public void SaveUMAName(){
		umaChoser.SaveAssetName ();
	}


}
