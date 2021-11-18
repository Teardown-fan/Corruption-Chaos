using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFeatures : MonoBehaviour
{
    public int featureCount = 0;
    public int maxFeatureCount = 20;
    public GameObject[] features;
    public int featureLength = 1;
    public float spawnHeight = 10;
    public float spawnX = 10;
    public UIManager uiScript;

    void Start()
    {
        uiScript = GameObject.Find("Managers").GetComponent<UIManager>();
    }

    void Update()
    {
        if (!uiScript.paused)
        {
            if (featureCount < maxFeatureCount)
            {
                int selectedFeature = Random.Range(0, featureLength + 1);
                GameObject feature = features[selectedFeature];
                Vector3 spawnPos = new Vector3(transform.position.x, Random.Range(-spawnHeight, spawnHeight) + transform.position.y, 0);
                Quaternion spawnRot = new Quaternion(0, 0, 0, 1);
                GameObject featureObj = Instantiate(feature, spawnPos, spawnRot);
                featureCount += 1;
            }
        }
    }
}
