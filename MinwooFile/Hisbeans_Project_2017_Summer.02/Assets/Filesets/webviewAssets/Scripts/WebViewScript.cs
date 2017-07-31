
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WebViewScript : MonoBehaviour
{

    private WebViewObject webViewObject;

    // Use this for initialization
    void Start()
    {
        StartWebView();

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Destroy(webViewObject);
                return;
            }
        }
    }

    public void StartWebView()
    {
        string strUrl = "http://52.79.169.121/%EA%B5%90%EC%9C%A1%EC%98%81%EC%83%81/%EC%A3%BC%EB%AC%B8-%EB%B0%9B%EA%B8%B0/";
        webViewObject = (new GameObject("WebViewObject")).AddComponent<WebViewObject>();

        webViewObject.Init((msg) => { Debug.Log(string.Format("CallFromJS[{0}]", msg)); });

        webViewObject.LoadURL(strUrl);
        webViewObject.SetVisibility(true);
        webViewObject.SetMargins(50, 50, 50, 50);

    }
}

