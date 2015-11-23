﻿import clr
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

class ActionResult(DataResult):
    def __init__(self):
        DataResult.__init__(self)
        self.PrizeStr = []
        self.isPass = 0
        self.GuideId = 0
        self.anotherGift = []

def getUrlElement(httpGet, parent):
    urlParam = UrlParam()
    if httpGet.Contains("GuideId"):
        urlParam.GuideId = httpGet.GetIntValue("GuideId")
    else:
        urlParam.Result = False
        return urlParam
    return urlParam

def takeAction(urlParam, parent):
    actionResult = ActionResult()
    userId = str(parent.Current.UserId)
    contextUser = PersonalCacheStruct.Get[GameUser](userId)
    userExtend = contextUser.UserExtend;
    tjxNoviceGuideService = TjxNoviceGuideService(parent.Current.UserId)
    if tjxNoviceGuideService.HasClose:
        actionResult.isPass = 1
        return actionResult
    actionResult.PrizeStr = tjxNoviceGuideService.DoPrize(urlParam.GuideId)
    result = tjxNoviceGuideService.Check()
    if userExtend and userExtend.NoviceIsPase == True:
        # 直接跳过新手引导
        actionResult.isPass = 1
    else:
        if result:
            if result[0]:
                guideInfo = result[1]
                if guideInfo:
                    actionResult.GuideId = guideInfo.GuideId
            else:
                actionResult.isPass = 1
    return actionResult

def buildPacket(writer, urlParam, actionResult):
    writer.PushIntoStack(actionResult.isPass)
    writer.PushIntoStack(actionResult.GuideId)
    if actionResult.PrizeStr:
        writer.PushIntoStack(actionResult.PrizeStr.Count)
        for prize in actionResult.PrizeStr:
            ds = DataStruct()
            ds.PushIntoStack(prize.ItemName)
            ds.PushIntoStack(prize.HeadID)
            ds.PushIntoStack(1)
            writer.PushIntoStack(ds)
    else:
        writer.PushIntoStack(0)
    return True;