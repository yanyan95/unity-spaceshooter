﻿using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

    public float
        rotationsPerSecond = 0.1f;
    public bool
        _____________________________;
    public int
        levelShown = 0;


	// Update is called once per frame
	void Update () {
        //read the current shield level form the Hero SIngleton
        int currLevel = Mathf.FloorToInt(Hero.S.shieldLevel);
        //if this is different from levelShown...
        if(levelShown != currLevel)
        {
            levelShown = currLevel;
            Material mat = this.GetComponent<Renderer>().material;
            //adjust the texture offset to show different shield level
            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0);
        }
        //rotate the shield a bit every second
        float rZ = (rotationsPerSecond * Time.time * 360) % 360f;
        transform.rotation = Quaternion.Euler(0, 0, rZ);
	}
}
