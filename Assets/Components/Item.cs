using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	Rigidbody2D rb;
	public int speed = -1;
	public int point = 500;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Use this for initialization
	void Start (){
		rb.velocity = transform.right.normalized * speed;
	}

	void OnTriggerEnter2D (Collider2D col){
		FindObjectOfType<Score>().AddPoint(point);
		Destroy(gameObject);
	}

}
