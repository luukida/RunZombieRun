using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenLogin : MonoBehaviour
{
    public TMP_InputField usernameInputField;
    public TMP_InputField passwordInputField;

    public void Login()
    {
        if (LoginValidation())
        {
            Debug.Log("Login efetuado com sucesso!");
        }
        else
        {
            Debug.Log("Verifique as informações e tente novamente.");
        }
    }

    private bool LoginValidation()
    {
        string username = usernameInputField.text;
        string password = passwordInputField.text;

        if (string.IsNullOrEmpty(username))
            return false;
        if (!username.Contains("@"))
            return false;
        if (!username.Contains("."))
            return false;
        if (username.Length < 5)
            return false;

        if (string.IsNullOrEmpty(password))
            return false;
        if (password.Length < 6)
            return false;

        return true;
    }

    public void ForgotPassword()
    {
        Application.OpenURL("http://www.google.com");
    }
}
