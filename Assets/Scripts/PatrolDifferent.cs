using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolDifferent : MonoBehaviour {

	// Use this for initialization
	public float t = 0f;
	public Transform[] Waypoints;
	public float Speed = 3;
	public int curWayPoint;
	public bool doPatrol = true;
	public Vector3 Target;
	public Vector3 MoveDirection;
	public Vector3 Velocity;
	public int Type = 0;

	public float duration = 1.0f;

	public AnimationCurve curve = AnimationCurve.Linear(1.0f, 1.0f, 0.0f, 0.0f);
	void Start()
	{

	}
	private void Update()
	{
		
		if (curWayPoint < Waypoints.Length)
		{
			Target = Waypoints[curWayPoint].position;
			MoveDirection = Target - transform.position;
			Velocity = GetComponent<Rigidbody>().velocity;
			
			if (MoveDirection.magnitude < 1)
			{
				curWayPoint++;
				Speed = 3;
			}
			// Linear
			if (Type == 0)
			{
				Velocity = MoveDirection.normalized * Speed;
			}
			// EaseIn
			if (Type == 1)
			{
				t += Time.deltaTime;
				float s = t / duration;
				transform.position = Vector3.Lerp(Waypoints[0].position, Waypoints[1].position, curve.Evaluate(s));
				//Velocity = MoveDirection.normalized * ( Speed + );

			}
			// EaseOut
			if (Type == 2)
			{
				t += Time.deltaTime;
				float s = t / duration;
				transform.position = Vector3.Lerp(Waypoints[0].position, Waypoints[1].position, curve.Evaluate(s));
				//Velocity = MoveDirection.normalized * Speed;
			}
			// EaseINOUT
			if (Type == 3)
			{
				
				t += Time.deltaTime;
				float s = t / duration;
				transform.position = Vector3.Lerp(Waypoints[0].position, Waypoints[1].position, curve.Evaluate(s));
				curWayPoint++;
				if (MoveDirection.magnitude < 1)
				{
					//Velocity = MoveDirection.normalized * Speed;
					curWayPoint--;
				}

			}

		}
		else
		{
			if (doPatrol)
			{
				curWayPoint = 0;
			}
			else
			{
				Velocity = Vector3.zero;
			}
		}

		GetComponent<Rigidbody>().velocity = Velocity;
		//transform.LookAt(Target);

	}
}
