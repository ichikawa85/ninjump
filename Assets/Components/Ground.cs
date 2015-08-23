using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	public float speed = -3f;
	private Vector2 director;

	
	// Use this for initialization
	void Start (){
		director = new Vector2 (-30f, 18f);

		Destroy (gameObject, 5);
	}

	void Update(){
		transform.position = Vector2.MoveTowards (transform.position, director, speed * Time.deltaTime);
	}
}
