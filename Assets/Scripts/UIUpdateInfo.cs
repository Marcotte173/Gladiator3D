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
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().Head.text      = Marcotte.GetComponent<Sockets>().Socket[1].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().Torso.text     = Marcotte.GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightArm.text  = Marcotte.GetComponent<Sockets>().Socket[2].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightHand.text = Marcotte.GetComponent<Sockets>().Socket[2].GetComponent<Sockets>().Socket[1].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftArm.text   = Marcotte.GetComponent<Sockets>().Socket[3].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftHand.text  = Marcotte.GetComponent<Sockets>().Socket[3].GetComponent<Sockets>().Socket[1].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightLeg.text  = Marcotte.GetComponent<Sockets>().Socket[4].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftLeg.text   = Marcotte.GetComponent<Sockets>().Socket[5].GetComponent<HealthStatus>().Status;
        // Marcotte Armor Status
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().Head.text      = Marcotte.GetComponent<Sockets>().Socket[1].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().Torso.text     = Marcotte.GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightArm.text  = Marcotte.GetComponent<Sockets>().Socket[2].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightHand.text = Marcotte.GetComponent<Sockets>().Socket[2].GetComponent<Sockets>().Socket[1].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftArm.text   = Marcotte.GetComponent<Sockets>().Socket[3].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftHand.text  = Marcotte.GetComponent<Sockets>().Socket[3].GetComponent<Sockets>().Socket[1].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightLeg.text  = Marcotte.GetComponent<Sockets>().Socket[4].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        MarcotteInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftLeg.text   = Marcotte.GetComponent<Sockets>().Socket[5].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        //Lincoln Body status
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().Head.text      = Lincoln.GetComponent<Sockets>().Socket[1].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().Torso.text     = Lincoln.GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightArm.text  = Lincoln.GetComponent<Sockets>().Socket[2].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightHand.text = Lincoln.GetComponent<Sockets>().Socket[2].GetComponent<Sockets>().Socket[1].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftArm.text   = Lincoln.GetComponent<Sockets>().Socket[3].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftHand.text  = Lincoln.GetComponent<Sockets>().Socket[3].GetComponent<Sockets>().Socket[1].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().RightLeg.text  = Lincoln.GetComponent<Sockets>().Socket[4].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Status.GetComponent<UISlot>().LeftLeg.text   = Lincoln.GetComponent<Sockets>().Socket[5].GetComponent<HealthStatus>().Status;
        // Marcotte Armor Status
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().Head.text       = Lincoln.GetComponent<Sockets>().Socket[1].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().Torso.text      = Lincoln.GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightArm.text   = Lincoln.GetComponent<Sockets>().Socket[2].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightHand.text  = Lincoln.GetComponent<Sockets>().Socket[2].GetComponent<Sockets>().Socket[1].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftArm.text    = Lincoln.GetComponent<Sockets>().Socket[3].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftHand.text   = Lincoln.GetComponent<Sockets>().Socket[3].GetComponent<Sockets>().Socket[1].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().RightLeg.text   = Lincoln.GetComponent<Sockets>().Socket[4].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
        LincolnInfo.GetComponent<UIUpdateStatus>().Armor.GetComponent<UISlot>().LeftLeg.text    = Lincoln.GetComponent<Sockets>().Socket[5].GetComponent<Sockets>().Socket[0].GetComponent<HealthStatus>().Status;
    }
}
