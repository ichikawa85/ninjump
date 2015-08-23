using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageManager : MonoBehaviour {

	const float MoveX = 14f;
	
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
			float y = Random.Range (0f, 4f);
			switch(rand){
			case 1:
				int ene_rand = Random.Range(1, 5);
				transform.position = v_enemy;
				Instantiate (enemys[ene_rand], transform.position, transform.rotation);
				break;
			case 2:
				transform.position = v_item;
				transform.position = new Vector2(MoveX, y);
				Instantiate (enemy, transform.position, transfor
				break;
			case 2:
				transform.position = new Vector2(MoveX, y);
<<<<<<< HEAD

=======
>>>>>>> 4f99716daba671358829e35a925875cb041a57f2
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
<<<<<<< HEAD
<<<<<<< HEAD
			transform.position = v_ground;
=======
			transform.position = new Vector2(MoveX, 18f);
>>>>>>> fc41459... 敵とアイテムの出現位置変更対応
=======
			transform.position = new Vector2(MoveX, 18f);
>>>>>>> 4f99716daba671358829e35a925875cb041a57f2
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
