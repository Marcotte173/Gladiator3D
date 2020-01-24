using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITextColourChange : MonoBehaviour
{
    UISlot slot;
    private void Start()
    {
        slot = GetComponent<UISlot>();
    }
    void Update()
    {
        slot.Head.color = (slot.Head.text == "None")      ? Color.white : (slot.Head.text == "Damaged") ? Color.cyan : (slot.Head.text == "Destroyed") ? Color.red : (slot.Head.text == "Severely Damaged") ? Color.yellow : Color.green;
        slot.Torso.color = (slot.Torso.text == "None")     ? Color.white : (slot.Torso.text == "Damaged") ? Color.cyan : (slot.Torso.text == "Destroyed") ? Color.red : (slot.Torso.text == "Severely Damaged") ? Color.yellow : Color.green;
        slot.RightArm.color = (slot.RightArm.text == "None")  ? Color.white : (slot.RightArm.text == "Damaged") ? Color.cyan : (slot.RightArm.text == "Destroyed") ? Color.red : (slot.RightArm.text == "Severely Damaged") ? Color.yellow : Color.green;
        slot.RightHand.color = (slot.RightHand.text == "None") ? Color.white : (slot.RightHand.text == "Damaged") ? Color.cyan : (slot.RightHand.text == "Destroyed") ? Color.red : (slot.RightHand.text == "Severely Damaged") ? Color.yellow : Color.green;
        slot.LeftArm.color = (slot.LeftArm.text == "None")   ? Color.white : (slot.LeftArm.text == "Damaged") ? Color.cyan : (slot.LeftArm.text == "Destroyed") ? Color.red : (slot.LeftArm.text == "Severely Damaged") ? Color.yellow : Color.green;
        slot.LeftHand.color = (slot.LeftHand.text == "None")  ? Color.white : (slot.LeftHand.text == "Damaged") ? Color.cyan : (slot.LeftHand.text == "Destroyed") ? Color.red : (slot.LeftHand.text == "Severely Damaged") ? Color.yellow : Color.green;
        slot.RightLeg.color = (slot.RightLeg.text == "None")  ? Color.white : (slot.RightLeg.text == "Damaged") ? Color.cyan : (slot.RightLeg.text == "Destroyed") ? Color.red : (slot.RightLeg.text == "Severely Damaged") ? Color.yellow : Color.green;
        slot.LeftLeg.color = (slot.LeftLeg.text == "None")   ? Color.white : (slot.LeftLeg.text == "Damaged") ? Color.cyan : (slot.LeftLeg.text == "Destroyed") ? Color.red : (slot.LeftLeg.text == "Severely Damaged") ? Color.yellow : Color.green;
    }
}
