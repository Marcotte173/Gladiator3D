using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdateInfo : MonoBehaviour
{
    public GameObject MarcotteInfo;
    public GameObject LincolnInfo;
    public HealthStatus Marcotte;
    public HealthStatus Lincoln;
private void Update()
    {
        //Marcotte Body status
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().Head.text = Marcotte.GetComponent<Sockets>().Socket[1].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().Torso.text = Marcotte.GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightArm.text = Marcotte.GetComponent<Sockets>().Socket[2].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightHand.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftArm.text = Marcotte.GetComponent<Sockets>().Socket[3].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftHand.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightLeg.text = Marcotte.GetComponent<Sockets>().Socket[4].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftLeg.text = Marcotte.GetComponent<Sockets>().Socket[5].GetComponent<HealthStatus>().Status;
        // Marcotte Armor Status
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().Head.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().Torso.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightArm.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightHand.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftArm.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftHand.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightLeg.text = "";
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftLeg.text = "";
        //Lincoln Body status
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().Head.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().Torso.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightArm.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightHand.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftArm.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftHand.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightLeg.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftLeg.text = "";
        // Marcotte Armor Status
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().Head.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().Torso.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightArm.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightHand.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftArm.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftHand.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightLeg.text = "";
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftLeg.text = "";
    }
}
