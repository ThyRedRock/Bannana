/* Unity Game Programming
 * Banana Breakout
 * Author name
 * Project date
 */

using UnityEngine;
using UnityEngine.InputSystem;

public class TrampolineScript : MonoBehaviour 
{
	// Movement Speed
	public float speed = 3.0F;

	// Use this for initialization
	void Start () 
	{

	}

	void Update()
	{
		// allow the user to control the trampoline with left/right arrow keys
		Vector2 moveValue = InputSystem.actions.FindAction("Move").ReadValue<Vector2>();
		transform.Translate(moveValue.x * Time.deltaTime * speed, 0, 0);
	}
}
