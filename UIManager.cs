using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{ 
    public MyModelsManager ModelsManager; // Drag and drop the ModelsManager object from the scene here
    public Sprite[] SelectedSprites; 
    public Sprite[] NormalSprites;
    public Image[] SliderImages;

    // Use this for initialization
    void Start()
    {
        DeselectAll();
    }

    void Update()
    {
        // You can add any required update logic here if needed.
    }

    public void SelectModel(int index)
    {
        ModelsManager.SetModel(index); 
        DeselectAll();
        SliderImages[index].sprite = SelectedSprites[index];
    }

    public void DeselectAll()
    {
        for (int i = 0; i < SliderImages.Length; i++)
        {
            SliderImages[i].sprite = NormalSprites[i];
        }
    }
}
