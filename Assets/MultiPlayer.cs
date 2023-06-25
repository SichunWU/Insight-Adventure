using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;
using Fusion;
//using UnityEditor.VersionControl;


public class MultiPlayer : NetworkBehaviour
{
    public Text _message;
    //public TextMeshProUGUI input;
    //public TextMeshProUGUI username;
    public Text input;
    public Text username;
    public string user = "Set Your Name!";
    public void SetUsername()
    {
        user = username.text;
    }

    public void Rpc_CallMessage()
    {
        string message = input.text;
        Rpc_SendMessage(user, message);
    }

    [Rpc(RpcSources.All, RpcTargets.All)]

    public void Rpc_SendMessage(string user, string message, RpcInfo rpcInfo = default)
    {
        _message.text += $"{user}: {message}\n";
    }
}
