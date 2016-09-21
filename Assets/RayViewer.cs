using UnityEngine;
using System.Collections;

public class RayViewer : MonoBehaviour {

	public float laserRange = 50f;
	private Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponentInParent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 lineOrigin = camera.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
		Debug.DrawRay (lineOrigin, camera.transform.forward * laserRange, Color.green);
	}
}
