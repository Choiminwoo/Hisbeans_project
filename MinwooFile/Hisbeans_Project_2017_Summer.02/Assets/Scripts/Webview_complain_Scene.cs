using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Webview_complain_Scene : MonoBehaviour
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
        string strUrl = "http://52.79.169.121/%ea%b5%90%ec%9c%a1%ec%98%81%ec%83%81/%ec%bb%b4%ed%94%8c%eb%a0%88%ec%9d%b8-%ec%9e%85%eb%a7%9b/";
        webViewObject = (new GameObject("WebViewObject")).AddComponent<WebViewObject>();

        webViewObject.Init((msg) => { Debug.Log(string.Format("CallFromJS[{0}]", msg)); });

        webViewObject.LoadURL(strUrl);
        webViewObject.SetVisibility(true);
        webViewObject.SetMargins(50, 50, 50, 50);

    }
}

