using UnityEngine;
using System.Collections;
using Vuforia;


public class ModelHandler : MonoBehaviour, ITrackerEventHandler
{
	private GameObject _testCube;
	private TrackableBehaviour _aTrackablebehaviour;

	private bool isRendered = false;

	// Use this for initialization
	void Start () 
	{
		_testCube = GameObject.Find ("TestCube");
	}
		
	// Update is called once per frame
	void Update () 
	{
			
	}

	private void OnTrackingfound()
	{
		isRendered = true;
	}

	private void OnTrackingLost()
	{
		isRendered = false;
	}
}