using UnityEngine;
using System.Collections;

public class SendMessageAsButton : MonoBehaviour 
{
    public GameObject aimObj;
    public string method = "";
    public string option = "";

    public string aimObjName = "";

    void Start()
    {
        if (aimObjName != "")
        {
            aimObj = GameObject.Find(aimObjName);
        }
    }

    public void PushButton()
    {
        if (option == "SendThisGO()")
        {
            aimObj.SendMessage(method, this.gameObject);
            return;
        }

        aimObj.SendMessage(method, option);
    }

}
