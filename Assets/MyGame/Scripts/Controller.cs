using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeScene01()
    {
        SceneManager.LoadScene("Screen01");
    }
    public void ChangeScene02()
    {
        SceneManager.LoadScene("Screen02");
    }
    public void ChangeScene03()
    {
        SceneManager.LoadScene("Screen03");
    }

}