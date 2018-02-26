using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string heroName = "Thanos";
		string equippedWeapon = "Ifinity Gauntlet";
		string favoriteFurniture = "Throne";

		string favoritePlanet;

		favoritePlanet = "Earth";

		Debug.Log (favoritePlanet);
		Debug.Log (heroName);
		Debug.Log (equippedWeapon);
		Debug.Log (favoriteFurniture.ToUpper());

		int hp = 100;
		float shieldPower = 76.5f;
		int laserDamage = 30;
		double actuallyDamagePercent = .05;

		int actualDamage = (int)(laserDamage * actuallyDamagePercent);

		hp -= actualDamage; // hp = hp - actualDamage

		shieldPower = shieldPower = (laserDamage - actualDamage);

		Debug.Log ("HP: " + hp);
		Debug.Log ("Shield Power: " + shieldPower);

		int slices = 10 / 5;
		Debug.Log ("slices of Pizza: " + slices);

		int newDamage = 10 / 3;
		print (newDamage);

		int remainder = 10 % 3;
		print ("10 / 3 = " + newDamage + " remainder " + remainder);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
