using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    IEnumerator MyMethod()
    {
        //Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
        //Debug.Log("After Waiting 2 Seconds");
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyMethod());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
