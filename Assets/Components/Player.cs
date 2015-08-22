using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int hp = 3;

	Rigidbody2D rb;
	public int moveSpeed = 2;
	public LayerMask groundLayer; //地面のレイヤー
	float jumpForce = 500; //ジャンプ力
	bool isGrounded; //着地しているかの判定

	public float distance;
	public Vector2 UnitVector;

	[SerializeField]
	private GameObject bullet;

	Vector2 hitPoint1, hitPoint2;

	void Start (){
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
	{
		if (Input.GetMouseButtonDown(0)) {
			HitFirst();
		}

		if(Input.GetMouseButton(0)){
			HitLast();
		}
		
		if(Input.GetMouseButtonUp(0)){
			// 距離
			distance = Vector2.Distance(hitPoint2, hitPoint1);
			Debug.Log(hitPoint1);
			Debug.Log(hitPoint2);

			// 大きさが1以上で、ベクトルがy軸に対して30度未満のものをフリック入力として受け取る。
			if(distance > 1f){
				Debug.Log("Flick");
				Instantiate (bullet, transform.position, transform.rotation);
			}else if(isGrounded && distance <= 1f){
				// Empty
				Jump ();
			}
		}
	}

	// 最初の位置を得る。
	void HitFirst(){
		Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		hitPoint1= worldPoint;
	}
	// 最後の位置を得る。
	void HitLast(){
		Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		hitPoint2= worldPoint;
	}

void OnCollisionEnter2D (Collision2D col){
		string layerName = LayerMask.LayerToName (col.gameObject.layer);

	if (layerName == "Ground") {
			isGrounded = true;
			Vector2 temp = gameObject.transform.localScale;
			temp.x *= -1;
			gameObject.transform.localScale = temp;
		}
	}

	void Jump (){
		//上方向へ力を加える
		Debug.Log("Jump");
		rb.AddForce (Vector2.up * jumpForce);
		isGrounded = false;
	}
}
