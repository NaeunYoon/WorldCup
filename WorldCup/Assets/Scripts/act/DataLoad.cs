using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class DataLoad : MonoBehaviour
{

    public string[] directories;
    public string path = @"C:\이상형월드컵이미지";
    public int folderLength = 0;
    public void Create()
    {
        LoadDataFromC();
    }
    
    public void LoadDataFromC()
    {
        string[] directorypath = Directory.GetDirectories(path);
        directories = new string[directorypath.Length];
        
        for (int i = 0; i < directorypath.Length; i++)
        {
            string name = Path.GetFileName(directorypath[i]);
            directories[i] = name;
            
            Dictionary<string, Sprite> imgDict = new Dictionary<string, Sprite>();
            
            string[] imageFiles = Directory.GetFiles(directorypath[i], "*.*")
                .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                .ToArray();

            for (int j = 0; j < imageFiles.Length; j++)
            {
                string fileName = Path.GetFileName(imageFiles[j]); 
                Sprite imageSprite = LoadSpriteFromPath(imageFiles[j]);

                if (imageSprite != null)
                {
                    imgDict.Add(fileName, imageSprite); 
                }
                else
                {
                    Debug.LogWarning("Failed to load image: " + fileName);
                }
            }
            App.inst.uiMgr.matchTableMgr.directoryImgList.Add(imgDict);
        }
    }
    
    Sprite LoadSpriteFromPath(string path)
    {
        if (File.Exists(path))
        {
            byte[] fileData = File.ReadAllBytes(path);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); 
            return Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        }
        return null;
    }
}
