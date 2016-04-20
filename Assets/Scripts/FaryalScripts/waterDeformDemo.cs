using UnityEngine;
using System.Collections;

public class waterDeformDemo : MonoBehaviour {

	public float waveFrequency;
	public float waveHeight; 

	MeshFilter meshFilter; //tells unity which model to use
	Vector3[] unchangedVertices; //keeps a clen copy of the vertex info

	// Use this for initialization
	void Start () {
		meshFilter = GetComponent<MeshFilter> ();
		unchangedVertices = meshFilter.mesh.vertices.Clone() as Vector3[];
	}
	
	// Update is called once per frame
	void Update () {

		//step 1 : make a clean copy of the vertices to work from 
		Vector3[] deformedVertices = unchangedVertices.Clone () as Vector3[];

		// step 2: deform the vertices using MATH 
		for (int i = 0; i < deformedVertices.Length; i++) {
			deformedVertices [i] += Vector3.up * Mathf.Sin (waveFrequency * (Time.time + i)) *waveHeight;
		}

		meshFilter.mesh.vertices = deformedVertices;
		//step 4: recalculate normals which tell unity which direction the object is facing
		meshFilter.mesh.RecalculateNormals ();

		//step 5: scroll the materials offset

		GetComponent<Renderer> ().material.mainTextureOffset += new Vector2 (-Time.deltaTime, Time.deltaTime) *0.03f;
			
		//step 6: put the deformed mesh into the meshCollider

		GetComponent<MeshCollider> ().sharedMesh = meshFilter.mesh;
	
	}

}
