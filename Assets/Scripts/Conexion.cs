using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]
public class User
{
    public string userName;
    public string password;
}

public class UserList
{
    public List<User> users;
}

public class Conexion : MonoBehaviour
{
    public InputField usuarioInputField;
    public InputField passwordInputField;
    public Button loginButton;
    public Text messageText;

    private List<User> users = new List<User>();


    void Start()
    {
        loginButton.onClick.AddListener(Login);

        GetHttpsData();
    }

    public void GetHttpsData()
    {
        try
        {
            string url = "http://masterfarm.somee.com/api/User";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string jsonResponse = reader.ReadToEnd();
                Debug.Log(jsonResponse);

                UserList userList = JsonUtility.FromJson<UserList>("{\"users\":" + jsonResponse + "}");

                users = userList.users;
            }
            else
            {
                Debug.LogError("Failed to get data. Status Code: " + response.StatusCode);
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error:" + e.Message);
        }
    }

    public void Login()
    {
        string userName = usuarioInputField.text;
        string password = passwordInputField.text;

        bool usuarioAutenticado = false;

        foreach (User user in users)
        {
            if (user.userName == userName && user.password == password)
            {
                usuarioAutenticado = true;
                // Mostrar mensaje de éxito
                //messageText.text = "¡Inicio de sesión exitoso!";
                //Debug.Log("Usuario autenticado: " + userName);
                SceneManager.LoadScene("MenuInicial");
                break;
            }
        }

        if (!usuarioAutenticado)
        {
            // Mostrar mensaje de error
            messageText.text = "Usuario o contraseña incorrectos.";
            Debug.LogWarning("Usuario o contraseña incorrectos.");
        }
    }
}