"""chat list"""
import clr, sys
import json
import ReferenceLib
from action import *
from System import *
from ZyGames.Framework.Common import *
from ZyGames.Framework.Game.Contract import *
from ZyGames.Framework.Game.Service import *
from ZyGames.Framework.RPC.Sockets import *
from ZyGames.Framework.Cache.Generic import *
from GameServer.Script.CsScript.Com import *
from GameServer.Script.Model import *
#引用示例
#clr.AddReference('ZyGames.Framework.Common');
#from ZyGames.Framework.Common.Log import *

class ChatData():

    def __init__(self):
        self.Id = 0
        self.Message = ''
        self.UserId = 0
        self.Sender = ''
        self.SendTime = ''
        return

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
    return urlParam

def takeAction(urlParam, parent):
    actionResult = ActionResult()
    user = parent.Current.User
    chatservice = MyChatService(user)
    actionResult.chatList = chatservice.PopMessages()
    return actionResult

def buildPacket(urlParam, actionResult):
    list = []
    for chat in actionResult.chatList:
        data = ChatData()
        data.Id = chat.Version
        data.UserId = chat.FromUserID
        data.Message = chat.Content
        data.Sender = GetUserName(chat.FromUserID)
        data.SendTime = chat.SendDate.ToString("HH:mm:ss")
        list.append(data)

    result = JsonDataResult(urlParam)
    result.setBody(list)
    jsonStr = json.dumps(result, default=convert_to_builtin_type)
    return jsonStr


def GetUserName(userId):
    cache = MemoryCacheStruct[ChatUser]()
    result = cache.TryGet(str(userId))
    if result[0] == True:
        return result[1].UserName
    else:
        return ''

def convert_to_builtin_type(obj): 
    d = {  }
    d.update(obj.__dict__)
    return d