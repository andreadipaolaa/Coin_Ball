using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using Newtonsoft.Json;

public class PlayFabManager : MonoBehaviour
{

    [Header("UI")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;


    public void RegisterButton(){
        if(passwordInput.text.Lenght < 0){
            messageText.text ="password to short!";
            return
        }
       var request = new RegisterPlayFabUserRequest {
        Email = emailInput.text;
        Password = passwordInput.text,
        RequiredBothUsernameAndEmail = false
       };
       PlayFabClientAPI.RegisterPlayFabUserRequest(request, OnRegisterSuccess, OnError);
    }

    void OnRegisterSuccess(RegisterPlayFabUserRequest result){
        messageText.text = "Registered and logged in!";
    }

    public void LoginButton(){
        var request = new LoginWithEmailAddressRequest {
            Email = emailInput.text,
            Password = passwordInput.text
        };
        PlayFabClientAPI.LoginWithEmailAddressRequest(request, OnLoginSuccess, OnError);
    }


    public void ResetPasswordButton(){
        var request = new SendAccountRecoveryEmailRequest {
            Email = emailInput.text,
            TitleId = "9FE78"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }

    void OnPasswordReset(SendAccountRecoveryEmailResult result){
        messageText.text = "Password reset mail sent!";
    }



    // Start is called before the first frame update
    void Start()
    {
        Login();
    }

    void Login(){
        var request = new LoginWithCustomIDRequest {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnError);
   }

   void OnLoginSuccess(LoginResult result){
        messageText.text ="Logged in!";
        Debug.Log("Succesful login/account create");
   }

   void OnError (PlayFabError error){
        messageText.text= error.ErrorMessage;
        Debug.Log(error.GenerateErrorReport());
   }


}
