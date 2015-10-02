using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	GameObject playerRef;
	public Rigidbody enemyBody;
	public Transform missile;
	public bool enemyHitting;
	//gameObject.GetComponent<Collider>
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHitting == true) {
			OnTriggerEnter (); 
		}
		//playerRef = GameObject.Find ("Player");
	}

	void OnTriggerEnter2D(){
		enemyHitting = true;
	}


	void OnTriggerEnter() {
		
		Instantiate (missile);
	}//Vector2 (GetComponent<transform>.position), Quaternion.identity);
		//Destroy (other.gameObject);
		//Destroy (gameObject);
	}

