using UnityEngine;
using System.Collections;

public class platform_move06 : MonoBehaviour {

	public int hight = 10;//max height of Box's movement
	public float yCenter = 15f;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

			transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time,15.0f) + 10, transform.position.z );

		}
	}
