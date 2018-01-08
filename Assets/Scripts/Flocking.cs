using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flocking : MonoBehaviour
{
	public float speed;
	Vector3 target;
	Vector3 start;
	Vector3 pos;
	void Start()
	{
		start = transform.position;
		pos = transform.position;
	}

	void Update()
	{

			pos = Input.mousePosition;
			pos.z = 45;
			pos = Camera.main.ScreenToWorldPoint(pos);
			transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
		Vector3 mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

		Vector2 direction = new Vector2(
			mousePosition.x - transform.position.x,
			mousePosition.y - transform.position.y);

		transform.up = direction;
	}
}
		//-----
		//public Vector2 location = Vector2.zero;
		//public Vector2 velocity;
		//Vector2 goalPos = Vector2.zero;
		//Vector2 currentForce;
		//// Use this for initialization
		//void Start()
		//{
		//	velocity = new Vector2(Random.Range(0.01f, 0.1f), Random.Range(0.01f, 0.1f));
		//	location = new Vector2(Input.mousePosition.x - transform.position.x,
		//		Input.mousePosition.y - transform.position.y);
		//	//location = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		//}

		//Vector2 seek(Vector2 target)
		//{
		//	return (target - location);
		//}

		//void applyForce(Vector2 f)
		//{
		//	Vector3 force = new Vector3(f.x, f.y, 0);
		//	//this.GetComponent<Rigidbody2D>().AddForce(force);
		//	//Debug.DrawRay(this.transform.position, force, Color.white);
		//}

		//void flock()
		//{
		//	location = this.transform.position;
		//	velocity = this.GetComponent<Rigidbody2D>().velocity;

		//	Vector2 gl;
		//	gl = seek(goalPos);
		//	currentForce = gl;
		//	currentForce = currentForce.normalized;

		//	applyForce(currentForce);
		//}

		//// Update is called once per frame
		//void Update () {
		//	Vector3 mousePosition = Input.mousePosition;
		//	mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

		//	Vector2 direction = new Vector2(
		//		mousePosition.x - transform.position.x,
		//		mousePosition.y - transform.position.y);

		//	transform.up = direction;
		//	flock();

		//}
	//}
