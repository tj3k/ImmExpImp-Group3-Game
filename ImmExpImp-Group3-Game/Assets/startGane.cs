using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startGane : MonoBehaviour
{

    public GameObject PlayTxt;
    public GameObject panel;
    public GameObject crashTxt;
    // Start is called before the first frame update
    void Start()
    {
        PlayTxt.SetActive(true);
        panel.SetActive(true);
        crashTxt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hideText()
    {
        PlayTxt.SetActive(false);
        panel.SetActive(false);
        crashTxt.SetActive(true);
        Invoke("nextLvl", 5);
    }

    public void nextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
