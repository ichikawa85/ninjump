using UnityEngine;
using System.Collections;

public class EndingSceneController : MonoBehaviour 
{
	public float speed = 100F;
	public float stopTime = 60F;
	public float time = 0;
	public float returnTime = 10F;

	public RectTransform rollTrans = null;

	private bool fadeStart = false;

	// Update is called once per frame
	void Update () 
	{
		// エンディングのスクロールをする.
		if (time < stopTime) 
		{
			Vector3 pos = rollTrans.position;
			pos.y += speed * Time.deltaTime;
			rollTrans.position = pos;
		}
		else 
		{
			if( !fadeStart) // フェードインをする.
			{
				this.SendMessage("fadeOut");
				fadeStart = true;
			}

			if (stopTime + returnTime < time) // 時間が来たら、タイトルに戻る.
			{
				Application.LoadLevel ("title");
			} 
		}

		time += Time.deltaTime;
	}
}
