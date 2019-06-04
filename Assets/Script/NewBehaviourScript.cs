using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

	public GameObject obj;
	MeshFilter objFilter;
	MeshRenderer objRenderer;

	Vector3[] vertices;
	int[] triangles;

	// Start is called before the first frame update
	void Start()
    {
		objFilter=obj.GetComponent<MeshFilter>();
		objRenderer = obj.GetComponent<MeshRenderer>();

		Mesh mesh = new Mesh();

		vertices = new Vector3[GetComponent<MeshFilter>().mesh.vertices.Length];
		triangles = new int[GetComponent<MeshFilter>().mesh.triangles.Length];


		for (int i = 0; i < GetComponent<MeshFilter>().mesh.vertices.Length; i++)
		{
			var vector=Camera.main.WorldToViewportPoint(GetComponent<MeshFilter>().mesh.vertices[i]);
			vector.z = 0;
			vertices[i] = Camera.main.ViewportToWorldPoint(vector);
		}

		for (int i = 0; i < GetComponent<MeshFilter>().mesh.triangles.Length; i++)
		{
			triangles[i] = GetComponent<MeshFilter>().mesh.triangles[i];
		}

		mesh.vertices = vertices;
		mesh.triangles = triangles;


		mesh.RecalculateNormals();
		mesh.RecalculateTangents();

		objFilter.mesh = mesh;
	}

    // Update is called once per frame
    void Update()
    {
		Mesh mesh = new Mesh();

		for (int i = 0; i < GetComponent<MeshFilter>().mesh.vertices.Length; i++)
		{
			var vector = Camera.main.WorldToViewportPoint(GetComponent<MeshFilter>().mesh.vertices[i]);
			vertices[i] = Camera.main.ViewportToWorldPoint(vector);
		}

		for (int i = 0; i < GetComponent<MeshFilter>().mesh.triangles.Length; i++)
		{
			triangles[i] = GetComponent<MeshFilter>().mesh.triangles[i];
		}

		obj.transform.rotation = transform.rotation;

		mesh.vertices = vertices;
		mesh.triangles = triangles;


		mesh.RecalculateNormals();
		mesh.RecalculateTangents();

		objFilter.mesh = mesh;
	}
}
