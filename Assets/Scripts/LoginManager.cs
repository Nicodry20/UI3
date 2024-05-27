using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public Button BtnAceptar;
    public InputField inputPassword;

    public string Password;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CheckPassword()
    {
        if (inputPassword.text == Password)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
