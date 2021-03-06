﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models
{
    /// <summary>
    /// 表示返回结果的状态码，及描述
    /// </summary>
    public enum Status
    {
        //普遍
        FAILURE=-1,
        SUCCESS=0,
        //格式
        FORMAT_ERROR=1,
        //数据库数据不一致
        DATABASE_OPERATOR_ERROR=2,
        DATABASE_CONTENT_ERROR=3,
        //无内容
        NONFOUND=4,
        //参数错误
        ARGUMENT_ERROR=5,
        //无权限
        PERMISSION_DENIED=6,
        //文件格式不支持
        FILE_NOT_SUPPORT=7,
        FILE_PATH_ERROR=8,
        //服务器异常
        SERVER_EXCEPTION=9,
        //会议正在开始
        MEETING_OPENING=10,
        //会议已结束
        MEETING_OPENED=11,
        //文件转换失败
        FILE_CONVERT_FAIL=12,
        //文件转换异常
        FILE_CONVERT_EXCEPTION=13,
        //时间设置错误
        TIME_SET_ERROR = 14,

        //设备不足
        DEVICE_LACK = 15,
        //已存在
        NAME_EXIST = 16,
        //设备已占用
        DEVICE_OCCUPY = 17,
        //主讲人已被议程使用
        DELEGATE_USED = 18
    }

    public class Message
    {
        public static Dictionary<int, string> msgs;
        static Message()
        {
            msgs = new Dictionary<int, string>();
            msgs.Add((int)Status.SUCCESS, "操作成功");
            msgs.Add((int)Status.FAILURE, "操作失败");
            msgs.Add((int)Status.ARGUMENT_ERROR, "参数错误");
            msgs.Add((int)Status.FORMAT_ERROR, "参数格式出错");
            msgs.Add((int)Status.PERMISSION_DENIED, "无权限");
            msgs.Add((int)Status.NONFOUND, "无数据");
            msgs.Add((int)Status.DATABASE_CONTENT_ERROR, "数据库内容出错");
            msgs.Add((int)Status.DATABASE_OPERATOR_ERROR, "数据库操作出错");
            msgs.Add((int)Status.FILE_NOT_SUPPORT, "文件格式不支持上传");
            msgs.Add((int)Status.FILE_PATH_ERROR, "文件路径或文件不存在");
            msgs.Add((int)Status.SERVER_EXCEPTION, "服务器异常");
            msgs.Add((int)Status.MEETING_OPENING, "会议正在开启，无法修改");
            msgs.Add((int)Status.MEETING_OPENED, "会议已结束");
            msgs.Add((int)Status.FILE_CONVERT_FAIL, "文件转换失败");
            msgs.Add((int)Status.FILE_CONVERT_EXCEPTION, "文件转换异常");
            msgs.Add((int)Status.TIME_SET_ERROR, "时间设置错误");
            msgs.Add((int)Status.DEVICE_LACK, "设备数量不足");
            msgs.Add((int)Status.NAME_EXIST, "名称已存在");
            msgs.Add((int)Status.DEVICE_OCCUPY, "设备已占用");
            msgs.Add((int)Status.DELEGATE_USED, "主讲人已绑定议程");
        }
    }

    public class System_Info
    {
        public static Dictionary<int, string> info;
        static System_Info()
        {
            info = new Dictionary<int, string>();
           
        }
    }
}