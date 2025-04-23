using UnityEngine;

public class SunControl : MonoBehaviour {

	//Range for min/max values of variable
	[Range(-10f, 10f)]
	public float sunRotationSpeed_x, sunRotationSpeed_y;

	// Sun Movement
	//Rotate on the X axis - Sun Rotation Speed_x
	//Negative numbers will have it rise, the higher the number the faster rotation from sunrise to sunset
	void Update () {
		gameObject.transform.Rotate (sunRotationSpeed_x * Time.deltaTime, sunRotationSpeed_y * Time.deltaTime, 0);
	}
}
