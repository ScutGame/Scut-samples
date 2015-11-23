import clr
import sys
import ReferenceLib

from action import *
from System import *
from System.Collections.Generic import *
from ZyGames.Framework.Cache.Generic import *
from ZyGames.Framework.Common.Log import *
from ZyGames.Tianjiexing.Model import *
from ZyGames.Tianjiexing.BLL import *
from ZyGames.Tianjiexing.Lang import *
from ZyGames.Framework.Cache.Generic import *
from ZyGames.Framework.Game.Service import *
from ZyGames.Framework.Common import *
from ZyGames.Framework.Cache.Generic import *
from ZyGames.Tianjiexing.Model.Config import *
from ZyGames.Tianjiexing.Component.Chat import *


#新手引导进度
class UrlParam(HttpParam):
    def __init__(self):
        HttpParam.__init__(self)
        self.GuideId = 0
        self.Ops = 0

class ActionResult(DataResult):
    def __init__(self):
        DataResult.__init__(self)
        self.isPass = 0

def getUrlElement(httpGet, parent):
    urlParam = UrlParam()
    if httpGet.Contains("GuideId")\
    and httpGet.Contains("Ops"):
        urlParam.GuideId = httpGet.GetIntValue("GuideId")
        urlParam.Ops = httpGet.GetIntValue("Ops")
    else:
        urlParam.Result = False
    return urlParam

def takeAction(urlParam, parent):
    actionResult = ActionResult()
    userId = str(parent.Current.UserId)
    contextUser = PersonalCacheStruct.Get[GameUser](userId)
    userExtend = contextUser.UserExtend;
    tjxNoviceGuideService = TjxNoviceGuideService(parent.Current.UserId)
    if urlParam.Ops == 0:
        result = tjxNoviceGuideService.Check()
        if result:
            if result[0]:
                actionResult.isPass = 1
                return actionResult
            actionResult.GuideInfo = result[1]

            if tjxNoviceGuideService.DoComplated(urlParam.GuideId):
                parent.ErrorCode = LanguageManager.GetLang().ErrorCode
                parent.ErrorInfo = LanguageManager.GetLang().LoadDataError
                actionResult.Result = False
                return actionResult
    else:
        if userExtend:
            userExtend.NoviceIsPase = True
        else:
            userExtend = GameUserExtend()
            userExtend.NoviceIsPase = True
    return actionResult

def buildPacket(writer, urlParam, actionResult):
    return True;