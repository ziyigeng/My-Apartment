using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealName : MonoBehaviour
{
    private GameObject canvas; 
    // Start is called before the first frame update
    void Start()
    {
        canvas = transform.Find("Canvas").gameObject;
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
    }
}
