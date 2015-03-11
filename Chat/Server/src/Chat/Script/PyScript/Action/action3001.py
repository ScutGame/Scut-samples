"""Send chat"""
import clr, sys
from action import *
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
    if httpGet.Contains("message"):
        urlParam._message = httpGet.GetStringValue("message")
    else:
        urlParam.Result = False

    return urlParam

def takeAction(urlParam, parent):
    actionResult = ActionResult()
    user = parent.Current.User
    return actionResult

def buildPacket(urlParam, actionResult):

    return ""