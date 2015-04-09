"""Send chat"""
import clr, sys
import json
import ReferenceLib
from action import *
from ZyGames.Framework.Common import *
from ZyGames.Framework.Game.Contract import *
from ZyGames.Framework.Game.Service import *
from ZyGames.Framework.RPC.Sockets import *
from GameServer.Script.CsScript.Com import *
from GameServer.Script.Model import *
#引用示例
#clr.AddReference('ZyGames.Framework.Common');
#from ZyGames.Framework.Common.Log import *

class UrlParam(HttpParam):
    def __init__(self):
        HttpParam.__init__(self)


class ActionResult(DataResult):
    def __init__(self):
        DataResult.__init__(self)


def getUrlElement(httpGet, parent):
    urlParam = UrlParam()
    urlParam.MsgId = httpGet.GetMsgId()
    urlParam.ActionId = httpGet.GetActionId()
    if httpGet.Contains("message"):
        urlParam._message = httpGet.GetStringValue("message")
    else:
        urlParam.Result = False

    return urlParam

def takeAction(urlParam, parent):
    actionResult = ActionResult()
    user = parent.Current.User
    chatservice = MyChatService(user)
    chatservice.Send(urlParam._message)
    return actionResult

def buildPacket(urlParam, actionResult):
	
    ActionFactory.SendAction(GameSession.GetOnlineAll(), 3002, None, sendCallback, OpCode.Text, 0);
	
    result = JsonDataResult(urlParam)
    result.setBody(True)
    jsonStr = json.dumps(result, default=convert_to_builtin_type)
    return jsonStr

def sendCallback(session, asyncResult):
    # send to client result.
    return

def convert_to_builtin_type(obj): 
    d = {  }
    d.update(obj.__dict__)
    return d