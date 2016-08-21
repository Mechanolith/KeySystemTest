using UnityEngine;
using System.Collections;

public class SendCode : MonoBehaviour {
    public string testCode;
    public string url = "http://www.handsomedragongames.com/KeyTest.php"; //Need to update this to the correct address. Also make it changable.

    void Start() 
    {
        SendToServer(testCode, url);
    }

	void Update () {
	    if(Input.GetKeyDown(KeyCode.P))
        {
            SendToServer(testCode, url);
        }
	}

    public void SendToServer(string code, string targetURL) 
    {
        WWWForm outForm = new WWWForm();
        string steamID = "TEST";
        //Get steamID.

        //Send both to server.
        outForm.AddField("Key", code);
        outForm.AddField("ID", steamID);
        WWW www = new WWW(targetURL, outForm);

        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(WWW www) 
    {
        Debug.Log("Begin Post Request");
        yield return www;

        //Error Check
        if (www.error == null)
        {
            Debug.Log("Post Request SUCCESS!");
            ParseResults(www);
        }
        else 
        {
            Debug.LogWarning("Post Request FAILED!");
        }
    }

    //See if the code was found successfully.
    //If it was, distribute the correct reward.
    void ParseResults(WWW www) 
    {
        Debug.Log(www.text);
    }
}
