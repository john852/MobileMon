using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    readonly Quaternion BUILD_CAMERA_ANGLE = new Quaternion(0.7071068f, 0f, 0f, 0.7071068f);
    readonly Vector3 BUILD_CAMERA_POS = new Vector3(0, 211, 0);

    readonly Quaternion PLAY_CAMERA_ANGLE = new Quaternion(0.131f, 0f, 0f, 0.991f);
    readonly Vector3 PLAY_CAMERA_POS = new Vector3(0, 100, -100);

    Camera m_Camera;

	// Use this for initialization
	void Start () {
        m_Camera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void ChangeToBuildCamera()
    {
        m_Camera.transform.SetPositionAndRotation(BUILD_CAMERA_POS, BUILD_CAMERA_ANGLE);
        m_Camera.orthographic = true;
        //todo: change these values
        m_Camera.orthographicSize = 130;
    }

    public void ChangeToPlayCamera()
    {
        m_Camera.transform.SetPositionAndRotation(PLAY_CAMERA_POS, PLAY_CAMERA_ANGLE);
        m_Camera.orthographic = false;

    }
}
