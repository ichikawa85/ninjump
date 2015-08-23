using UnityEngine;
using System.Collections;

public class Oni : Enemy 
{
	Animator anim;

	[SerializeField]
	float appearTime = 10F; // 鬼の出現時間.
	float nowTime = 0F;

	void Start()
	{
		anim = this.GetComponent<Animator> ();
		anim.enabled = false;
	}

	void Update()
	{
		if( IsAppearOni())
		{
			anim.enabled = true;
		}

		nowTime += Time.deltaTime;
	}

	new void OnTriggerEnter2D (Collider2D col)
	{
		// まだ鬼が出てなければ,ダメージ判定をしない.
		if (!IsAppearOni()) 
		{
			return;
		}

		//base.OnTriggerEnter2D (col);

		if (hp < 0F) 
		{
			anim.SetTrigger ("IsDead");
		} 
		else {
			anim.SetTrigger("HitDamage");
		}
	}


	public void StopDeadMotion()
	{
		GameObject.Instantiate<GameObject> (Resources.Load<GameObject>("Prefabs/SceneClear/GameClearCanvas"));
	}

	private bool IsAppearOni()
	{
		return appearTime < nowTime;
	}
}
