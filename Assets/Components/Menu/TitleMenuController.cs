using UnityEngine;
using System.Collections;

public class TitleMenuController : MonoBehaviour 
{
	GameObject helpCanvas = null;

	/// <summary>
	/// ステージ選択画面を呼び出す.
	/// </summary>
	public void CallSelectStageMenu()
	{
		GameObject.Instantiate<GameObject>( Resources.Load<GameObject>("Prefabs/Menu/StageSelectCanvas"));
		GameObject.Find ("StartTap").SetActive(false);
	}

	public void CallSkyScene()
	{
		Application.LoadLevel ("sky");
	}
		
	public void CallCityScene()
	{
		Application.LoadLevel ("city");
	}
	
	public void CallSpaceScene()
	{
		Application.LoadLevel ("space");
	}

	public void CallHelpCanvas()
	{
		 helpCanvas = GameObject.Instantiate<GameObject>( Resources.Load<GameObject>("Prefabs/Menu/HelpCanvas"));
	}

	public void CloseHelpCanvas()
	{
		Destroy (helpCanvas);
	}
}
