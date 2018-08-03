using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public const int MODE_PLAY = 0;
    public const int MODE_BUILD = 1;

    public static int GameMode = MODE_PLAY;
    public static PlayerData m_playerData;

    public GameObject m_gameCamera;
    public GameObject m_gridPlane;
    public BlockManager m_blockManager;


    // Use this for initialization
    void Start () {
        if (m_playerData == null)
        {
            //TODO: load player data here
            m_playerData = new PlayerData();
        }
        m_gameCamera = GameObject.Find("MainCamera");
        m_gridPlane = GameObject.Find("GridPlane");
        m_blockManager = GameObject.Find("Blocks").GetComponent<BlockManager>();
        m_gridPlane.SetActive(false);
        m_blockManager.InitializeBlocks();
    }
	
	// Update is called once per frame
	//void Update () {
		
	//}

    public void SwitchMode()
    {
        switch (GameMode)
        {
            case MODE_PLAY:
                ChangeToBuildMode();
                break;
            case MODE_BUILD:
            default:
                ChangeToPlayMode();
                break;
        }
    }

    private void ChangeToBuildMode()
    {
        m_gameCamera.GetComponent<CameraMovement>().ChangeToBuildCamera();
        GameMode = MODE_BUILD;
        m_gridPlane.SetActive(true);
    }

    private void ChangeToPlayMode()
    {
        m_gameCamera.GetComponent<CameraMovement>().ChangeToPlayCamera();
        GameMode = MODE_PLAY;
        m_gridPlane.SetActive(false);
    }
}
