using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyModelsManager : MonoBehaviour
{
    public GameObject[] Models;

    void Start()
    {
        DisableAll();
    }

    void DisableAll()
    {
        foreach (var item in Models)
        {
            item.SetActive(false);
        }
    }

    public void SetModel(int index) // Make the method public
    {
        DisableAll();
        Models[index].SetActive(true);
    }
}
