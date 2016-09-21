using UnityEngine;
using System.Collections;

public class LightBlink : MonoBehaviour {

	public float waitingTime;

	IEnumerator BlinkLight ()
	{
		while (true)
		{
			GetComponent<Light>().enabled = !(GetComponent<Light>().enabled);
			yield return new WaitForSeconds(waitingTime);
		}
	}

	void Start() {
		waitingTime = Random.Range (0.1f, 3f);
		StartCoroutine (BlinkLight ());
	}
}
