using UnityEngine;
using System.Collections;

public class nc_waterdeform : MonoBehaviour {

	public float waveFrequency = 1f;
	public float waveHeight = 0.5f;


	// meshFilter tells Unity which model to use
	MeshFilter meshFilter;
	//Means its an array, list of Vector3's, keeps a clean copy of the vertex info
	Vector3[] unchangedVerticies;

	// Use this for initialization
	void Start () {
		meshFilter = GetComponent<MeshFilter>();
		//clone creates copy of variable, but separate copy
		unchangedVerticies = meshFilter.mesh.vertices.Clone() as Vector3[]; 
	
	}
	
	// Update is called once per frame
	void Update () {
		//step 1: make a clean copy of the model/ vertices to work from
		Vector3[] deformedVertices = unchangedVerticies.Clone () as Vector3[];

		// step 2: deform the vertices using function, sin function 
		// keep doing function until value surpasses the stated value, four loop function 
		for (int i = 0; i < deformedVertices.Length; i++) {
			//time must be input for sin function to constantly be changing, i will change the waves
			deformedVertices [i] += Vector3.up * Mathf.Sin ( waveFrequency * (Time.time + i)) * waveHeight;

		}

		//step: 3 put the vertices back into the mesh
		meshFilter.mesh.vertices = deformedVertices;

		//step: 4 recalculate "normals", tell unity which way a polygon is facing, blender
		meshFilter.mesh.RecalculateNormals();

		//step: 5 scroll the material's offset
		GetComponent<Renderer>().material.mainTextureOffset += 
			new Vector2( Time.deltaTime, Time.deltaTime );

		//step 6: put the mesh into the MeshCollider as well
		GetComponent<MeshCollider>().sharedMesh = meshFilter.mesh; 

	
	}
}
