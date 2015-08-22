using UnityEngine;
using System.Collections;

public class PlayerHPManager : MonoBehaviour {
	GameObject l1, l2, l3;
	Vector2 tmp1, tmp2, tmp3;
	Vector2 camOut;

	Player player_comp;
	[SerializeField]
	private GameObject player;

	// Use this for initialization
	void Start () {
		camOut = new Vector2(100f, 100f);
		player_comp = player.GetComponent<Player>();
		l1 = gameObject.transform.FindChild("Life1").gameObject;
		l2 = gameObject.transform.FindChild("Life2").gameObject;
		l3 = gameObject.transform.FindChild("Life3").gameObject;
		tmp1 = l1.transform.position;
		tmp2 = l2.transform.position;
		tmp3 = l3.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		switch(player_comp.hp){
		case 0: 
			l1.transform.position = camOut;
			l2.transform.position = camOut;
			l3.transform.position = camOut;
			break;
		case 1: 
			l1.transform.position = tmp1;
			l2.transform.position = camOut;
			l3.transform.position = camOut;
			break; 
		case 2:
			l1.transform.position = tmp1;
			l2.transform.position = tmp2;
			l3.transform.position = camOut;
			break;
		case 3: 
			l1.transform.position = tmp1;
			l2.transform.position = tmp2;
			l3.transform.position = tmp3;
			break;
		}

	}
}
