using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_to : MonoBehaviour
{
public float speed = 1.0f;
public float speed_manovr = 3.0f;
private CharacterController _charControler;

void Start() {
_charControler = GetComponent<CharacterController>();
}

void Update () {
	
	float deltaX = - Input.GetAxis("Horizontal") * speed_manovr;
	float deltaY = Input.GetAxis("Vertical") * speed_manovr;
	float deltaZ = speed;
	Vector3 movement = new Vector3(deltaZ,deltaY,deltaX);
	movement = Vector3.ClampMagnitude(movement,speed);
	
	movement*=Time.deltaTime;
	movement = transform.TransformDirection(movement);
	_charControler.Move(movement);
}
}