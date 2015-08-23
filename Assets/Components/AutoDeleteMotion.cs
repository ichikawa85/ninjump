using UnityEngine;
using System.Collections;

public class AutoDeleteMotion : StateMachineBehaviour
{

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		if (1F <= stateInfo.normalizedTime) 
		{
			GameObject.Destroy( animator.gameObject);
		}
	}
}
