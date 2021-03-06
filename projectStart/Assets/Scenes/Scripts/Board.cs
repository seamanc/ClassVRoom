﻿using System.Linq;
using UnityEngine;

/// <summary>
///  Sketchpad
/// </summary>
public class Board : MonoBehaviour
{
    //When the brush moves fast, does not appear to intermittent dots, it is necessary to interpolate between two points, that is, interpolation coefficients Lerp
    [Range(0, 1)]
    public float lerp = 0.05f;
    //Initialization background pictures
    public Texture2D initailizeTexture;
    //The current background image
    private Texture2D currentTexture;
    //Brush the location is mapped to the drawing board pictures UV coordinates
    private Vector2 paintPos;

    private bool isDrawing = false;//The current brush is not being on the drawing board
    //When leaving the position where the brush 
    private int lastPaintX;
    private int lastPaintY;
    //Brush size represents the color
    private int painterTipsWidth = 30;
    private int painterTipsHeight = 15;
    //The current size of the background picture drawing board
    private int textureWidth;
    private int textureHeight;

    //Brush color
    private Color32[] painterColor;

    private Color32[] currentColor;
    private Color32[] originColor;


    private void Start()
    {
        //Get the original image size 
        Texture2D originTexture = GetComponent<MeshRenderer>().material.mainTexture as Texture2D;
        textureWidth = originTexture.width;//1920   
        textureHeight = originTexture.height;//1080

        //Set the current picture
        currentTexture = new Texture2D(textureWidth, textureHeight, TextureFormat.RGBA32, false, true);
        currentTexture.SetPixels32(originTexture.GetPixels32());
        currentTexture.Apply();

        //Assigned to the blackboard
        GetComponent<MeshRenderer>().material.mainTexture = currentTexture;

        //Initialization brush color
        painterColor = Enumerable.Repeat<Color32>(new Color32(255, 0, 0, 255), painterTipsWidth * painterTipsHeight).ToArray<Color32>();
    }

    private void LateUpdate()
    {
        //A starting point for calculating the current brush, the color represented by
        int texPosX = (int)(paintPos.x * (float)textureWidth - (float)(painterTipsWidth / 2));
        int texPosY = (int)(paintPos.y * (float)textureHeight - (float)(painterTipsHeight / 2));
        if (isDrawing)
        {
            //Changing block where the pixel values ​​of the brush
            currentTexture.SetPixels32(texPosX, texPosY, painterTipsWidth, painterTipsHeight, painterColor);
            //If the fast-moving brush, then there will be intermittent phenomenon, so be interpolated
            if (lastPaintX != 0 && lastPaintY != 0)
            {
                int lerpCount = (int)(1 / lerp);
                for (int i = 0; i <= lerpCount; i++)
                {
                    int x = (int)Mathf.Lerp((float)lastPaintX, (float)texPosX, lerp);
                    int y = (int)Mathf.Lerp((float)lastPaintY, (float)texPosY, lerp);
                    currentTexture.SetPixels32(x, y, painterTipsWidth, painterTipsHeight, painterColor);
                }
            }
            currentTexture.Apply();
            lastPaintX = texPosX;
            lastPaintY = texPosY;
        }
        else
        {
            lastPaintX = lastPaintY = 0;
        }

    }

    /// <summary>
    ///  Set the current pen position where the UV
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public void SetPainterPositon(float x, float y)
    {
        paintPos.Set(x, y);
    }

    /// <summary>
    ///  Brush painting is currently not in
    /// </summary>
    public bool IsDrawing
    {
        get
        {
            return isDrawing;
        }
        set
        {
            isDrawing = value;
        }
    }

    /// <summary>
    ///  Using the current brush color on the drawing board are
    /// </summary>
    /// <param name="color"></param>
    /// 
    
    public void SetPainterColor(Color32 color)
    {
        if (!painterColor[0].IsEqual(color))
        {
            for (int i = 0; i < painterColor.Length; i++)
            {
                painterColor[i] = color;
            }
        }
    }
    

}
public static class MethodExtention
{
    /// <summary>
    ///  Color32 used to compare two types are not the same color
    /// </summary>
    /// <param name="origin"></param>
    /// <param name="compare"></param>
    /// <returns></returns>
    public static bool IsEqual(this Color32 origin, Color32 compare)
    {
        if (origin.g == compare.g && origin.r == compare.r)
        {
            if (origin.a == compare.a && origin.b == compare.b)
            {
                return true;
            }
        }
        return false;
    }
}