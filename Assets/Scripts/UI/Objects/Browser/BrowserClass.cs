﻿using PharoModule;
using System;

public class BrowserClass : BrowserObject
{
    public override async void onSelect()
    {
        if (theBrowser.class_list.last_selected != null)
            theBrowser.class_list.last_selected.onDeselect();
        if (theBrowser.methodList.last_selected != null)
            theBrowser.methodList.last_selected.onDeselect();
        theBrowser.class_list.last_selected = this;
        if (name != "template")
        {
            try
            {
                theBrowser.methodList.gameObject.SetActive(true);
                string sourceCode = await Pharo.Execute(name + " definition .");
                sourceCode = sourceCode.Substring(1, sourceCode.Length - 3);
                theBrowser.field.text = sourceCode;
                theBrowser.methodFilter.interactable = true;
                theBrowser.methodList.Load();
                theBrowser.classRemover.interactable = true;
                theBrowser.codeCubeLoader.interactable = true;
                theBrowser.codeCubeLoader2.interactable = true;

                if (theBrowser.senderList != null)
                {
                    theBrowser.senderList.gameObject.SetActive(true);
                    theBrowser.senderList.Load();
                }
            }
            catch (Exception e)
            {
                theBrowser.logText.text = "<color=#C63737>[Error] " + e.Message + "</color>";
            }
        }
        else
        {
            theBrowser.methodList.gameObject.SetActive(false);
            theBrowser.methodFilter.interactable = false;
            theBrowser.field.text = 
                "Object subclass: #NameOfSubclass\n" +
                    "    instanceVariableNames: ''\n" +
                    "    classVariableNames: ''\n" +
                    "    package: 'MyPackage'";
        }
        base.onSelect();
    }
}
