using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class PortalRenderer : MonoBehaviour
{
    public Camera cameraA;
	public Camera cameraB;

	public Material cameraMatA;
	public Material cameraMatB;

	// Use this for initialization
	void Start () {
	//	if (cameraA.targetTexture != null)
	//	{
	//		cameraA.targetTexture.Release();
	//	}
	//	cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
    //    cameraMatA=new Material(Shader.Find("Unlit/ScreenCutoutShader"));
    //    cameraMatA.mainTexture = cameraA.targetTexture;

		if (cameraB.targetTexture != null)
		{
			cameraB.targetTexture.Release();
		}
		cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
      //  cameraMatB= new Material(Shader.Find("Unlit/ScreenCutoutShader"));
        cameraMatB.mainTexture = cameraB.targetTexture;

	}
}
