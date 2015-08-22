using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public int hp = 10;
	public int speed = -1;
	Rigidbody2D rb;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	void Start (){
		rb.velocity = transform.right.normalized * speed;
	}
	
	// Update is called once per frame
	void Update () {
		if(hp <= 0 )
		{
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D (Collider2D col){
		// PlayerBulletのTransformを取得
		Transform playerBulletTransform = col.transform;
		// Bulletコンポーネントを取得
		Bullet bullet =  playerBulletTransform.GetComponent<Bullet>();
		// ヒットポイントを減らす
		Debug.Log(bullet.power);
		hp = hp - bullet.power;

	}
}
