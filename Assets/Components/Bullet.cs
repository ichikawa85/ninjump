using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	Rigidbody2D rb;
	public int speed = 10;
	public int power = 5;
	public int lifeTime = 2;

	// Use this for initialization
	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}

	void Start () {
		//rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.right.normalized * speed;

		Destroy (gameObject, lifeTime);
	}

	void OnTriggerEnter2D (Collider2D col){
		Destroy(gameObject);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
