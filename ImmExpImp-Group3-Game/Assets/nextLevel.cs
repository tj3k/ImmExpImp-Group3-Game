using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextlvl()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("hit1");
        }
    }
}
