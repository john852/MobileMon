using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    private uint m_nStat;
    public uint NStat
    {
        get { return m_nStat; }
        set { m_nStat = value; }
    }

    private enum statType { attack, defence, speed};
    private statType nType;

	// Use this for initialization
	void Start () {
        nType = statType.attack;
    }
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
