using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageManager : MonoBehaviour {
	
	public GameObject[] enemys;
	public GameObject item;
	public GameObject ground;

	public Vector2 v_enemy;
	public Vector2 v_item;
	public Vector2 v_ground;


	public float seconds = 5f;
	private int count = 0;
	
	public const float INTERVAL = 3.0f;
	public float timer = INTERVAL;

	private bool isGameOver;

	// Startメソッドをコルーチンとして呼び出す
	IEnumerator Start ()
	{
		while (true) {
			
			int rand = Random.Range(1, 4);
			switch(rand){
			case 1:
				int ene_rand = Random.Range(1, 5);
				transform.position = v_enemy;
				Instantiate (enemys[ene_rand], transform.position, transform.rotation);
				break;
			case 2:
				transform.position = v_item;
				Instantiate (item, transform.position, transform.rotation);
				break;
			case 3:

				break;
			default:
				break;
			}
			
			count++;
			
			// seconds秒待つ
			yield return new WaitForSeconds (seconds);
			
		}
	}
	
	private void Update()
	{
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			transform.position = v_ground;
			Instantiate (ground, transform.position, transform.rotation);
			if(seconds > 1.0f){
				//seconds = seconds - 0.5f;
			}
			timer = INTERVAL;
		}

		if(isGameOver)
		{
			if (Input.GetMouseButtonDown (0)) {
				Application.LoadLevel("title");
			}
		}
	}

	/// <summary>
	/// Displaies the game over.
	/// </summary>
	public void DisplayGameOver()
	{
		GameObject gameOver = GameObject.Find ("GameOverCanvas/GameOverText");
		if(gameOver == null)
		{
			return;
		}

		gameOver.GetComponent<Text> ().enabled = true;
		isGameOver = true;
	}
		
}
