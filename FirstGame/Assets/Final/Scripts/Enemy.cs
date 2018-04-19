using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public NavMeshAgent Agent;
	public Transform Player;
	public float speed = 6.0f;

	void start()
	{
		Agent = GetComponent<NavMeshAgent>();
	}

	void Update()
	{
		Agent.destination = Player.position;
	}

}
