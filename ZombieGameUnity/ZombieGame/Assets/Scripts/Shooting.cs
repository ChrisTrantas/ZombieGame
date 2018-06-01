using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {
    public Text inClip;
    public Text ammoLeft;
    public int clipCount;
    public const int PISTOLCLIPSIZE = 8;
    public int ammoCount;

    // Use this for initialization
    void Start ()
    {
        ammoCount = 40;
        clipCount = 8;
        inClip.text = clipCount.ToString();
        ammoLeft.text = ammoCount.ToString();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if(clipCount - 1 < 0 && ammoCount > 0)
            {
                clipCount = 8;
                ammoCount = ammoCount - clipCount;
                if(ammoCount < 0)
                {
                    ammoCount = 0;
                    clipCount = 0;
                }
            }
            clipCount--;
            if(clipCount == -1)
            {
                clipCount = 0;
            }
            inClip.text = clipCount.ToString();
            ammoLeft.text = ammoCount.ToString();           
        }

        if (Input.GetKeyDown("r") && ammoCount > 0)
        {
            Reload();
        }
           
    }

    void Reload()
    {
        //if (clipCount > 0 && ammoCount > 0)
        //{
        //    clipCount = 8;
        //    ammoCount = ammoCount - clipCount;
        //    if (ammoCount < 0)
        //    {
        //        ammoCount = 0;
        //        clipCount = 0;
        //    }
        //}
        //clipCount--;
        //if (clipCount == -1)
        //{
        //    clipCount = 0;
        //}
        //inClip.text = clipCount.ToString();
        //ammoLeft.text = ammoCount.ToString();
    }
}
