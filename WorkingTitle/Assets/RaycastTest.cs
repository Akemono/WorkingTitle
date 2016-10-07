using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RaycastTest : MonoBehaviour {
	public GameObject sunrot;
	//public GameObject terrain;
	//public List<Mesh> verts;
	public GameObject waterPlane;
	public Mesh waterMesh;
	public int vectorNum;

	void Start(){
		waterMesh = waterPlane.GetComponent<MeshFilter> ().sharedMesh;
	}

	void Update(){
		Vector3[] verts = waterMesh.vertices;
		for (int i = 0; i < verts.Length; i++) {
			Debug.DrawRay (verts [i], -sunrot.transform.forward, Color.red, 100, true);
			if(Physics.Raycast(new Ray(verts[i], -sunrot.transform.forward))){
				print ("Ray cast");
			}
		}
	}
}
