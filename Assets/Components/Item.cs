using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	Rigidbody2D rb;
	public int speed = -1;
	public int point = 500;
	public GameObject effect_item;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Use this for initialization
	void Start (){
		rb.velocity = transform.right.normalized * speed;
	}

	void OnTriggerEnter2D (Collider2D col){
		Instantiate (effect_item, transform.position, transform.rotation);
		FindObjectOfType<Score>().AddPoint(point);
		Destroy(gameObject);
	}

}
