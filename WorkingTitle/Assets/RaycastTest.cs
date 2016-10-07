using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RaycastTest : MonoBehaviour {
	public GameObject sunrot;
	public GameObject waterPlane;
	public Mesh waterMesh;
	public int vectorNum;

	void Start(){
		waterMesh = waterPlane.GetComponent<MeshFilter> ().sharedMesh;
	}

	void Update(){
		Vector3[] verts = waterMesh.vertices;
        for (int i = 0; i < verts.Length; i++) {
            Debug.DrawRay (verts [i] + waterPlane.transform.position, -sunrot.transform.forward * 300, Color.red);
			if(Physics.Raycast(new Ray(verts[i] + waterPlane.transform.position, sunrot.transform.position))){
                // TO DO: detecteer schaduw en bereken of er een wolk gevormd moet worden
                // deze if detecteert niet of er licht is op dit moment. 
                print ("Ray cast");
			}
		}
	}
}
