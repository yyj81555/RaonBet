using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BT_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Start_Button_Control()
    {
        SceneManager.LoadScene("Dunbarton_Office");
        Debug.Log("Scene Change");
    }
}
