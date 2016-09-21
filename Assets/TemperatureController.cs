using UnityEngine;
using System.Collections;

public class TemperatureController : MonoBehaviour {

    public float tempMin;
    public float tempMax;
    public float tempNow;

    public TextMesh tempTextMin;
    public TextMesh tempTextMax;
    public TextMesh tempTextNow;

    public GameObject tempCube;
    private Vector3 tempCubePosition;

	// Use this for initialization
	void Start () {
        tempCubePosition = tempCube.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        UpdateTemperature();
	}

    private void UpdateTemperature()
    {
        tempTextMin.text = tempMin + "°";
        tempTextMax.text = tempMax + "°";
        tempTextNow.text = tempNow + "°";

        Debug.Log("Before the change, tempCubePosition was " + tempCubePosition);
        tempCubePosition = new Vector3(tempCubePosition.x, tempNow.Remap(0, 100F, 0, 2.4f), tempCubePosition.z);
        Debug.Log("After the change, tempCubePosition was " + tempCubePosition);
        tempCube.transform.position = tempCubePosition;
    }
    
}
