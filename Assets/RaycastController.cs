using UnityEngine;
using System.Collections;

public class RaycastController : MonoBehaviour {

	private Camera camera;
	public Transform laserEnd;
	private AudioSource menuAudio;
	private LineRenderer laserLine;
	private float laserRange = 50f;
	private float nextFire;
	private WaitForSeconds shotDuration = new WaitForSeconds (0.1F);

	void Start () {
		laserLine = GetComponent<LineRenderer> ();
		menuAudio = GetComponent<AudioSource> ();
		camera = GetComponentInParent<Camera> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Fire1")) {

			laserLine.enabled = true;

			// StartCoroutine (ShotEffect ());

			Vector3 rayOrigin = camera.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0.0F));
			RaycastHit hit;

			laserLine.SetPosition (0, laserEnd.position);

			if (Physics.Raycast (rayOrigin, camera.transform.forward, out hit)) {
				laserLine.SetPosition (1, hit.point);
				Debug.Log ("Raycast hit");
			} else {
				laserLine.SetPosition (1, rayOrigin + (camera.transform.forward * laserRange));
			}

		} else {
			laserLine.enabled = false;
		}

	}


	/*private IEnumerator ShotEffect() {
		
		yield return shotDuration;
		laserLine.enabled = false;
	}*/

	

}
