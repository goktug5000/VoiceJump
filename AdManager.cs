using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour , IUnityAdsListener
{
    public void OnUnityAdsDidError(string message)
    {
        //throw new System.NotImplementedException();
        Debug.Log("OnUnityAdsDidError");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        //throw new System.NotImplementedException();
        Debug.Log("OnUnityAdsDidFinish");
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //throw new System.NotImplementedException();
        Debug.Log("OnUnityAdsDidStart");
    }

    public void OnUnityAdsReady(string placementId)
    {
        //throw new System.NotImplementedException();
        Debug.Log("OnUnityAdsReady");
    }

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("4781917");
        Advertisement.AddListener(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
                Advertisement.Banner.Show("Interstitial_Android");
            }

        }
    }
}
