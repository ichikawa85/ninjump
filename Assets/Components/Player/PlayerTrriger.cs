using UnityEngine;
using System.Collections;

public class PlayerTrriger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void OnTriggerEnter2D (Collider2D col){
		string layerName = LayerMask.LayerToName (col.gameObject.layer);
		if(layerName == "Enemy"){
			FindObjectOfType<Player>().Damage(1);
		}
	}
}
