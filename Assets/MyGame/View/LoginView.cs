using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using Facebook.Unity;
using MyGame.Controller;
using MyGame.Model;


namespace MyGame
{
    namespace View
    {

        public class LoginView : MonoBehaviour
        {

            public string playFabTitleId = string.Empty;
            public RawImage profilePic;
            public Text name;
            public Text livesValue;
            public Text gemsValue;
            public Text livesRegen;
            public GameObject buyLife;
            private bool areLivesCapped = true;
            private static LoginView instance;
            DateTime nextFreeTicket = new DateTime();

            public UnityEvent GetInventoryEvents = new UnityEvent();
            public UnityEvent PlayEvents = new UnityEvent();
            void Awake()
            {
                if (instance != null)
                {
                    Destroy(gameObject);
                }
                else
                {
                    instance = this;
                    DontDestroyOnLoad(gameObject);
                }

                if (!FB.IsInitialized)
                {
                    FB.Init(InitCallback, OnHideUnity);
                }
                else
                {
                    FB.ActivateApp();
                }

                GetInventoryEvents.AddListener(GetComponent<InventoryController>().loadPlayFabData);
                GetInventoryEvents.AddListener(GetComponent<InventoryController>().loadLeaderBoard);
                PlayEvents.AddListener(GetComponent<InventoryController>().checkInventory);
            }

            private void InitCallback()
            {
                if (FB.IsInitialized)
                {
                    FB.ActivateApp();
                    Time.timeScale = 0;

                    var perms = new List<string>() { "public_profile", "email", "user_friends" };
                    FB.LogInWithReadPermissions(perms, AuthCallBack);
                }
                else
                {
                    Debug.Log("Failed to Initialize the Facebook SDK");
                }
            }

            private void AuthCallBack(Facebook.Unity.ILoginResult result)
            {
                if (FB.IsLoggedIn)
                {

                    var aToken = AccessToken.CurrentAccessToken;

                    Debug.Log(aToken.UserId);

                    foreach (string perm in aToken.Permissions)
                    {
                        Debug.Log(perm);
                    }

                    LoginWithFacebook(aToken.TokenString, true, null);
                }
                else
                {
                    Debug.Log("User cancelled login");
                }
            }

            public void LoginWithFacebook(string token, bool createAccount = false, UnityAction errCallback = null)
            {
                LoginWithFacebookRequest request = new LoginWithFacebookRequest();
                request.AccessToken = token;
                request.TitleId = PlayFabSettings.TitleId;
                request.CreateAccount = createAccount;

                PlayFabClientAPI.LoginWithFacebook(request, OnLoginCB, OnApiCallError);
            }

            void OnLoginCB(PlayFab.ClientModels.LoginResult result)
            {
                Debug.Log(string.Format("Login Successful. Welcome Player:{0}!", result.PlayFabId));
                Debug.Log(string.Format("Your session ticket is: {0}", result.SessionTicket));
                FB.API("/me?fields=first_name", HttpMethod.GET, updatePlayFabUserTitleDisplayName);
                FB.API("me/picture?type=square&height=128&width=128", HttpMethod.GET, FbGetPicture);

                GetInventoryEvents.Invoke();
                PlayEvents.Invoke();

                OnHideUnity(true);

            }

            private void FbGetPicture(IGraphResult result)
            {
                if (result.Texture != null && profilePic != null)
                    profilePic.texture = result.Texture;
            }

            private void updatePlayFabUserTitleDisplayName(IGraphResult result)
            {

                string fbname = result.ResultDictionary["first_name"] as string;
                Debug.Log("your name is: " + fbname);
                if (name != null)
                    name.text = fbname;

                PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest { DisplayName = fbname }, null, null);

            }

            private void OnHideUnity(bool isGameShown)
            {
                if (!isGameShown)
                {
                    Time.timeScale = 0;
                }
                else
                {
                    Time.timeScale = 1;
                }
            }

            void OnApiCallError(PlayFabError err)
            {
                string http = string.Format("HTTP:{0}", err.HttpCode);
                string message = string.Format("ERROR:{0} -- {1}", err.Error, err.ErrorMessage);
                string details = string.Empty;

                if (err.ErrorDetails != null)
                {
                    foreach (var detail in err.ErrorDetails)
                    {
                        details += string.Format("{0} \n", detail.ToString());
                    }
                }

                Debug.LogError(string.Format("{0}\n {1}\n {2}\n", http, message, details));
            }
            void Start()
            {
                PlayFab.PlayFabSettings.TitleId = this.playFabTitleId;
                if (string.IsNullOrEmpty(PlayFab.PlayFabSettings.TitleId))
                {
                    Debug.LogWarning("Title Id was not set. To continue, enter your title id in the inspector.");
                }

                if (FB.IsLoggedIn)
                    PlayEvents.Invoke();
            }

            void Update()
            {
                if (this.areLivesCapped == false)
                {
                    if (nextFreeTicket.Subtract(DateTime.Now).TotalSeconds <= 0)
                    {
                        this.livesRegen.text = "Fetching timer...";
                        GetInventoryEvents.Invoke();
                    }
                    else
                    {
                        this.livesRegen.text = string.Format("Next life in: {0:n0} seconds", nextFreeTicket.Subtract(DateTime.Now).TotalSeconds);
                    }

                }
            }

            public void updateUI(GameModel.GameData data)
            {
                this.livesValue.text = string.Format("x{0}", data.live);
                this.gemsValue.text = string.Format("x{0}", data.gem);

                string textOut = string.Empty;
                if (data.live < data.liveMax)
                {
                    this.nextFreeTicket = DateTime.Now.AddSeconds(data.rechargeLiveTime);
                    textOut = string.Format("Next life in: {0:n0} seconds", data.rechargeLiveTime);
                    this.livesRegen.text = textOut;
                    this.buyLife.SetActive(true);
                    this.areLivesCapped = false;
                }
                else
                {
                    textOut = string.Format("Lives only regenerate to a maximum of {0}, and you currently have {1}.", data.liveMax, data.live);
                    this.livesRegen.text = string.Empty;
                    this.buyLife.SetActive(false);
                    this.areLivesCapped = true;
                }
                Debug.Log(textOut);

                if (FB.IsLoggedIn)
                    PlayEvents.Invoke();
            }
        }
    }
}
