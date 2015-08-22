using UnityEngine;
using System.Collections;
public class DontShowScreenReset : MonoBehaviour
{
	public float speed = 10;
	public int spriteCount = 1;
	public GameObject background;
	Vector3 spriteSize;
	void Start ()
	{
		spriteSize = GetComponent<SpriteRenderer> ().bounds.size;
	}
	void Update ()
	{
		transform.position += Vector3.left * speed * Time.deltaTime;
		#if UNITY_EDITOR
		var spritex = (transform.position + spriteSize / 2).x ;
		if( spritex < ScreenManager.Instance.screenRect.x )
		{
			OnBecameInvisible();
		}
		#endif
	}
	void OnBecameInvisible ()
	{
		var pos = transform.position;
		pos.x = background.transform.position.x + spriteSize.x;
		transform.position = pos;
	}
}
