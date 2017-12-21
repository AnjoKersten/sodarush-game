using UnityEngine;
using System.Collections;

public enum Buttons2{
	Right,
	Left,
	Up,
	Down,
	A,
	B
}

public enum Condition2{
	GreaterThan,
	LessThan
}

[System.Serializable]
public class InputAxisState2{
	public string axisName;
	public float offValue;
	public Buttons button;
	public Condition condition;

	public bool value{

		get{
			var val = Input.GetAxis(axisName);

			switch(condition){
			case Condition.GreaterThan:
				return val > offValue;
			case Condition.LessThan:
				return val < offValue;
			}

			return false;
		}

	}
}

public class InputManager2 : MonoBehaviour {

	public InputAxisState[] inputs;
	public InputState inputState;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		foreach (var input in inputs) {
			inputState.SetButtonValue(input.button, input.value);
		}
	}
}
