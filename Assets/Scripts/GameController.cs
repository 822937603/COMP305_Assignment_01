using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int missileCount;
	public GameObject missile;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void _GenerateMissile() {
		for (int count=0; count < this.missileCount; count++) {
			Instantiate(missile);
		}
	}
}
