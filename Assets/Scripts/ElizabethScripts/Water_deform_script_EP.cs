using UnityEngine;
using System.Collections;

public class Water_deform_script_EP : MonoBehaviour {

	MeshFilter meshFilter;

	Vector3[] unchangedVertecies;

	public float waveFrequency = 1f;

	public float waveHeight = 0.5f;


	// Use this for initialization
	void Start () {
	
		meshFilter = GetComponent<MeshFilter> ();
		unchangedVertecies = meshFilter.mesh.vertices.Clone () as Vector3[];
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3[] deformedVertecies = unchangedVertecies.Clone () as Vector3[];

		for (int i = 0; i < deformedVertecies.Length; i++) {
			deformedVertecies [i] += Vector3.up * Mathf.Sin (waveFrequency * (Time.time + i)) * waveHeight;
		}

		meshFilter.mesh.vertices = deformedVertecies;

		meshFilter.mesh.RecalculateNormals ();

		GetComponent<Renderer> ().material.mainTextureOffset += new Vector2 (Time.deltaTime, Time.deltaTime) * 0.5f;

		GetComponent<MeshCollider> ().sharedMesh = meshFilter.mesh;

	}
}
