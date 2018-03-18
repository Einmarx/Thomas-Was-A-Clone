using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject player;

    public Transform target;

    public float SmoothTime = 0.3F;

    private Vector3 offset;

    private Vector3 velocity = Vector3.zero;

	// Update is called once per frame
	void LateUpdate () {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -5));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
	}
}
