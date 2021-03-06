﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemUpdate : IUpdater
{
    public void Run()
    {
        Accessor<FollowTarget> modules = Accessor<FollowTarget>.Instance();
        
        foreach (var module in modules.GetAllModules())
        {
            module.Run();
        }
        
        Accessor<EdibleModule> editableModules = Accessor<EdibleModule>.Instance();
        Accessor<TargetEdible> modulesBis = Accessor<TargetEdible>.Instance();
        TargetEdible _nearest=null;
        foreach (var moduleBis in modulesBis.GetAllModules())
        {
            moduleBis.Run(editableModules);
        }
        
    }
}

public interface IUpdater
{
    void Run();
}
