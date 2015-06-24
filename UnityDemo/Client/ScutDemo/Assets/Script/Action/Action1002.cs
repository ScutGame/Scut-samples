using System;
using UnityEngine;

public class Action1002 : GameAction
{
    public class Passport
    {
        public string PassportId { get; set; }
        public string Password { get; set; }
    }
    private ActionResult actionResult;

    public Action1002()
        : base((int)ActionType.Regist)
    {
    }

    protected override void SendParameter(NetWriter writer, ActionParam actionParam)
    {
        //TODO:登录服务器获取账号
        //writer.writeString("Handler", "Passport");
        //writer.writeString("IMEI", GameSetting.Instance.DeviceID);

        writer.writeInt32("MobileType", GameSetting.Instance.MobileType);
        writer.writeInt32("GameID", GameSetting.Instance.GameID);
        writer.writeString("RetailID", GameSetting.Instance.RetailID);
        writer.writeString("ClientAppVersion", GameSetting.Instance.ClientAppVersion);
        writer.writeInt32("ScreenX", GameSetting.Instance.ScreenX);
        writer.writeInt32("ScreenY", GameSetting.Instance.ScreenY);
        writer.writeString("DeviceID", GameSetting.Instance.DeviceID);
        writer.writeInt32("ServerID", GameSetting.Instance.ServerID);

        
    }

    protected override void DecodePackage(NetReader reader)
    {
        actionResult = new ActionResult();
        actionResult["passportID"] = reader.readString();
        actionResult["password"] = reader.readString();

        //TODO:登录服务器获取账号
        //var passport = reader.readValue<Passport>();
        //actionResult["passportID"] = passport.PassportId;
        //actionResult["password"] = passport.Password;

    }

    public override ActionResult GetResponseData()
    {
        return actionResult;
    }
}
