using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClearSceneController : MonoBehaviour 
{
	private GameObject scoreObj;

	[SerializeField]
	private GameObject highScoreText = null;

	[SerializeField]
	private Text scoreText = null;

	private string saveKey = null;
	private int oldScore = 0;
	private int nowScore = 0;

	void Start()
	{
		Time.timeScale = 0F; // 処理と時間を止める.

		scoreObj = GameObject.Find("ScoreGUI");

		// 大量の情報を取得
		saveKey = "score" + Application.loadedLevelName;
		oldScore = PlayerPrefs.GetInt ( saveKey);
		nowScore = scoreObj.GetComponent<Score> ().GetPoint ();

		// スコアの記入
		scoreText.text = "Score : " + nowScore;
		if (oldScore < nowScore) 
		{
			highScoreText.SetActive(true);
			PlayerPrefs.SetInt (saveKey, nowScore); // スコアの更新.
		}
	}

	public void PushBackToSelectButton()
	{
		Time.timeScale = 1F; // 処理時間を戻す.

		Application.LoadLevel ("title");
	}
}
