using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	private InputState inputState;
	private Walk walkBehavior;
	private Animator animator;
	private CollisionState collisionState;
	private Duck duckBehavior;

	public PlayerMovement pm;

	void Awake(){
		inputState = GetComponent<InputState> ();
		walkBehavior = GetComponent<Walk> ();
		animator = GetComponent<Animator> ();
		collisionState = GetComponent<CollisionState> ();
		duckBehavior = GetComponent<Duck> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (collisionState.standing) {
			ChangeAnimationState(0);
			pm.enabled = true;
		}

		if (inputState.absVelX > 0) {
			ChangeAnimationState(1);
			pm.enabled = false;
		}

		if (inputState.absVelY > 0) {
			ChangeAnimationState(2);
			pm.enabled = false;
		}

		animator.speed = walkBehavior.running ? walkBehavior.runMultiplier : 1;

		if (duckBehavior.ducking) {
			ChangeAnimationState(3);
			pm.enabled = false;
		}

		if (!collisionState.standing && collisionState.onWall) {
			ChangeAnimationState(4);
			pm.enabled = false;
		}
	}

	void ChangeAnimationState(int value){
		animator.SetInteger ("AnimState", value);
	}
}
