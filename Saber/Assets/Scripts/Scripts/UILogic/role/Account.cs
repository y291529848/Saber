using KBEngine;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Account : KBEngine.GameObject
{
    public Dictionary<UInt64, Dictionary<string, object>> avatars = new Dictionary<UInt64, Dictionary<string, object>>();


    public Int64 lastSelCharacter;
    public void set_lastSelCharacter(object lastSelCharacter)
    {
        object current = getDefinedProperty("lastSelCharacter");
        this.lastSelCharacter = Int64.Parse(current.ToString());   
    }


    public Account()
    {
    }

    public override void __init__()
    {
        KBEngine.Event.registerIn(this, "reqCreateAvatar");
        // 触发登陆成功事件
        KBEngine.Event.fireOut("onLoginSuccessfully", new object[] { KBEngineApp.app.entity_uuid, id, this });
    }

    public override void onDestroy()
    {
        KBEngine.Event.deregisterIn(this);
    }

    public void onCreateAvatarFail()
    {
        // ui event
        KBEngine.Event.fireOut("onCreateAvatarFail");
    }

    public void reqCreateAvatar(Byte roleType, string name)
    {
        Dbg.DEBUG_MSG("Account::reqCreateAvatar: roleType=" + roleType);
        baseCall("reqCreateAvatar", roleType, name);

        PureMVC.Patterns.Facade.Instance.SendNotification(NotificationID.Create_Hide);
    }

    public void selectAvatarGame(UInt64 dbid)
    {
        Dbg.DEBUG_MSG("Account::selectAvatarGame: dbid=" + dbid);
        baseCall("selectAvatarGame", dbid);
    }
} 
