using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selection : MonoBehaviour
{

    private GameObject[] cl;

    private int index;
    private void Start()
    {
        index = PlayerPrefs.GetInt("CS");
        cl= new GameObject[transform.childCount];
        for(int i = 0; i< transform.childCount; i++)
            cl[i]= transform.GetChild(i).gameObject;

        foreach(GameObject go in cl)
            go.SetActive(false);

        if(cl[index])
            cl[index].SetActive(true);
        
    }
    
    public void ToggleLeft()
    {
        cl[index].SetActive(false);
       
        index--;
        if(index<0)
            index = cl.Length-1;
        
        cl[index].SetActive(true);

        
    }

    public void ToggleRight()
    {
        cl[index].SetActive(false);
       
        index++;
        if(index==cl.Length)
            index = 0;
        
        cl[index].SetActive(true);

        
    }

    public void Cnf()
    {
        PlayerPrefs.SetInt("CS", index);
        SceneManager.LoadScene("SampleScene");
    }

}
