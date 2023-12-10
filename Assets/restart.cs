using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "stop") {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		
	}
	if (other.gameObject.tag == "win") {
        SceneManager.LoadScene("test");
		
	}
}
}
