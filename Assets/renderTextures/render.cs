using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class render : MonoBehaviour
{
    [SerializeField] RenderTexture texture;
    [SerializeField] RenderTexture texture2;
    [SerializeField] RenderTexture texture3;
    string path = "C:\\Users\\Никита\\Desktop\\calculator";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    static void SaveRenderTexture(RenderTexture rt, string path)
    {
        RenderTexture.active = rt;
        Texture2D tex = new Texture2D(rt.width, rt.height, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        RenderTexture.active = null;
        var bytes = tex.EncodeToPNG();
        System.IO.File.WriteAllBytes(path, bytes);
        AssetDatabase.ImportAsset(path);
        Debug.Log($"Saved texture: {rt.width}x{rt.height} - " + path);
    }

    // Update is called once per frame
    void Update()
    {
        SaveRenderTexture(texture, path+"\\1.png");
        SaveRenderTexture(texture2, path+"\\2.png");
        SaveRenderTexture(texture3, path+"\\3.png");
    }
}
