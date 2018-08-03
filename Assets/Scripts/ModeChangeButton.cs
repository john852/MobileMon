using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeChangeButton : MonoBehaviour {

    public Text m_buttonText;

	// Use this for initialization
	void Start () {
        m_buttonText = this.transform.GetChild(0).GetComponent<Text>();

    }

    public void ChangeModeText()
    {
        if (GameManager.GameMode == GameManager.MODE_PLAY)
        {
            m_buttonText.text = "Build Mode";
        } else
        {
            m_buttonText.text = "Play Mode";

        }
    }
	

}
