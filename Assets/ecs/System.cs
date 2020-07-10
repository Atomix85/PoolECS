using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemUpdate : IUpdater
{
    public void Run()
    {
        Accessor<FollowTarget> modules = Accessor<FollowTarget>.Instance();
        
        foreach (var module in modules.GetAllModules())
        {
            if (module.target != null)
            {
                if (module.isFollow)
                {
                    module._navMeshAgent.isStopped = false;
                    module._navMeshAgent.SetDestination(module.target.position);
                }
                else
                {
                    module._navMeshAgent.isStopped = true;
                }
            }
            else
            {
                module._navMeshAgent.isStopped = true;
            }
        }
        
        Accessor<EdibleModule> editableModules = Accessor<EdibleModule>.Instance();
        Accessor<TargetEdible> modulesBis = Accessor<TargetEdible>.Instance();
        TargetEdible _nearest=null;
        foreach (var moduleBis in modulesBis.GetAllModules())
        {
            moduleBis._Navmesh.isStopped = false;

            EdibleModule neareast = null;

            if (moduleBis.isFollow)
            {
                foreach (var editableModule in editableModules.GetAllModules())
                {
                    if (!editableModule.edible) continue;
                    if (editableModule == null) continue;
                    if (neareast == null || Vector3.Distance(moduleBis.transform.position, editableModule.transform.position) <
                        Vector3.Distance(moduleBis.transform.position, neareast.transform.position))
                    {
                        neareast = editableModule;
                    }
                }

                if (neareast != null)
                    moduleBis._Navmesh.SetDestination(neareast.transform.position);
            }
            else
            {
                moduleBis._Navmesh.SetDestination(moduleBis.ennemy.transform.position);
            }
        }
        
    }
}

public interface IUpdater
{
    void Run();
}
