using UnityEngine;
using System.Collections;

public class SetSunLight : MonoBehaviour
{
    Material sky;

    // Use this for initialization
    void Start()
    {

        sky = RenderSettings.skybox;

    }
}