using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour {
	public float speed;
	public float tilt;
	private Rigidbody2D playerBody;
	public Boundary boundary;

	

	private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this._CheckInput ();
	}
	
	private void _CheckInput() {
		this._newPosition = gameObject.GetComponent<Transform> ().position; // current position
		
		if (Input.GetAxis ("Vertical") > 0) {
			this._newPosition.y += this.speed; // add move value to current position
		}
		
		
		if (Input.GetAxis ("Vertical") < 0) {
			this._newPosition.y -= this.speed; // subtract move value to current position
		}
		
		
		
		this._BoundaryCheck ();
		
		gameObject.GetComponent<Transform>().position = this._newPosition;
	}
	
	private void _BoundaryCheck() {
		if (this._newPosition.y < this.boundary.yMin) {
			this._newPosition.y = this.boundary.yMin;
		}

		if (this._newPosition.y > this.boundary.yMax) {
			this._newPosition.y = this.boundary.yMax;
		}
	}
}