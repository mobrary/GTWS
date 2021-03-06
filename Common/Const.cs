﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTWS
{
    public class Const
    {
        public const int IVS_EVENT_AUTO_CONNECT_SUCCEED = 10001;// 重新登录成功事件上报
        public const int IVS_EVENT_KEEP_ALIVE_FAILED = 10002;// 保活失败事件上报
        public const int IVS_EVENT_REALPLAY_FAILED = 10003;// 实时浏览异常事件上报
        public const int IVS_EVENT_RECORD_FAILED = 10004;// 录像异常事件上报
        public const int IVS_EVENT_DOWNLOAD_FAILED = 10005;// 录像下载异常事件上报
        public const int IVS_EVENT_REMOTE_PLAYBACK_FAILED = 10006;// 远程录像回放异常事件上报
        public const int IVS_EVENT_LOCAL_PLAYBACK_FAILED = 10007;// 本地录像回放异常事件上报
        public const int IVS_EVENT_TALKBACK_FAILED = 10008;// 语音对讲异常事件上报
        public const int IVS_EVENT_BROADCAST_FAILED = 10009;// 语音广播异常事件上报
        public const int IVS_EVENT_START_MULT_SNAPSHOT = 10010;// 开始连续抓拍
        public const int IVS_EVENT_STOP_MULT_SNAPSHOT = 10011;// 连续抓拍异常停止
        public const int IVS_EVENT_FINISHED_MULT_SNAPSHOT = 10012;// 连续抓拍完成
        public const int IVS_EVENT_REPORT_ALARM = 10013;// 告警上报
        public const int IVS_EVENT_FILE_BROADCAST_END = 10014;// 本地文件广播结束事件上报
        public const int IVS_EVENT_REMOTE_RECORD_STOP = 10015;// 远程录像停止
        public const int IVS_EVENT_REPORT_DEVICE = 10016;// 设备状态上报
        public const int IVS_EVENT_REPORT_ALARM_STATUS = 10017;// 告警状态上报
        public const int IVS_EVENT_USER_OFFLINE = 10019;// 用户下线通知
        public const int IVS_EVENT_RESUME_REALPLAY = 10020;// 启动实况重连
        public const int IVS_EVENT_RESUME_REALPLAY_OK = 10021;// 恢复实况浏览
        public const int IVS_EVENT_LOCAL_RECORD_SUCCESS = 10022;// 本地录像成功事件
        public const int IVS_EVENT_LOCAL_RECORD_EGENERIC = 10023;// 录像文件写入失败事件
        public const int IVS_EVENT_DO_LINKAGE_ACTION = 10024;// 告警联动动作执行通知
        public const int IVS_EVENT_FIND_DEVICE = 10025;// 发现前端设备事件
        public const int IVS_EVENT_OMU_REPORT_ALARM = 10026;// OMU将设备类告警发给CU的接口消息
        public const int IVS_EVENT_REPORT_WATERMARK_TIP = 10027;// 发现水印篡改提示（只有篡改开始时间）
        public const int IVS_EVENT_REPORT_WATERMARK_ALARM = 10028;// 水印告警记录产生通知（有篡改开始时间和停止时间）
        public const int IVS_EVENT_PTZ_LOCK = 10029;// 云镜锁定上报（云镜操作结果返回时告知客户端）
        public const int IVS_EVENT_OTHER = 10030;// 其他模式
        public const int IVS_EVENT_MANUAL_RECORD_STATE = 10031;// 手动录像状态通知
        public const int IVS_EVENT_STOP_LINKAGE_ACTION = 10032;// 告警联动动作停止通知
        public const int IVS_EVENT_DOWNLOAD_SUCCESS = 10033;// 录像下载完成事件上报
        public const int IVS_EVENT_PWD_EXPIRE_DAYS = 10034;// 用户密码过期天数
        public const int IVS_EVENT_PLAYER_BUFFER = 10035;// 客户端缓存通知
        public const int IVS_EVENT_PLAY_SOUND_FAILED = 10036;// 随路语音开启失败（已有语音对讲不可开启随路语音）
        public const int IVS_EVENT_PLAYER_WATER_MARK_EXCEPTION = 10037;// 水印异常事件上报
        public const int IVS_EVENT_IA_BA_LEARNING_SCHEDULE_REPORT = 10100;// 智能分析学习进度上报
        public const int IVS_EVENT_IA_FR_SCHEDULE_REPORT = 10101;// 智能分析人脸批量注册进度上报
        public const int IVS_EVENT_IA_PUSH_ALARM_LOCUS = 10102;// 智能分析轨迹推送
        public const int IVS_EVENT_IA_DRAW_OVER = 10103;// 智能分析绘图结束
        public const int IVS_EVENT_IA_ADDPLAN_SCHEDULE_REPORT = 10104;// 智能分析添加计划进度上报 
        public const int IVS_EVENT_MODE_CRUISE_RECORD_OVER = 10203;// 模式轨迹录制结束通知
        public const int IVS_EVENT_LOGIN_FAILED = 10301;// 客户端登录失败（例如，重连时密码改变）
        public const int IVS_EVENT_SHUTDOWN_STREAM = 10302;//客户端关闭视频业务通知
        public const int IVS_TIME_LEN = 20;// 时间长度
        public const int IVS_LONGITUDE_LATITUDE_LEN = 20;//经纬度长度
        public const int IVS_NAME_LEN = 128;// 名称长度
        public const int IVS_TICKET_LEN = 64;// 单点登录的Ticket长度
        public const int IVS_PWD_LEN = 64;// 密码长度(网络传输使用密文)
        public const int IVS_GROUP_CODE_LEN = 64;// 组编号长度
        public const int IVS_DESCRIBE_LEN = 256;// 描述长度
        public const int IVS_IP_LEN = 64;// IP长度
        public const int IVS_URL_LEN = 256;// URL长度
        public const int IVS_FILE_NAME_LEN = 256;// 文件名最大长度
        public const int IVS_MAX_NAME_LIST_LEN = 1024;// 名称列表最大长度，用逗号隔开
        public const int IVS_MACHINE_NAME_LEN = 128;// PC机器名长度
        public const int IVS_DOMAIN_LEN = 64;// Windows域名长度
        public const int IVS_PHONE_NUMBER_LEN = 64;// 电话号码最大长度
        public const int IVS_MAX_OPERATION_RIGHT = 128;// 操作权限个数上线
        public const int IVS_EMAILE_LEN = 128;// 用户Email长度
        public const int IVS_DEV_SERIALNO_LEN = 64;// 设备序列号长度
        public const int IVS_DEV_CODE_LEN = 64;// 设备编码最大长度
        public const int IVS_DEVICE_GROUP_LEN = 128;// 设备组编码最大长度
        public const int IVS_TAS_CODE_LEN = 32;// TAS编码长度
        public const int IVS_NVR_CODE_LEN = 32;// NVR编码长度
        public const int IVS_CLUSTER_CODE_LEN = 32;// 集群编码长度
        public const int IVS_DOMAIN_CODE_LEN = 32;// 域编码最大长度
        public const int IVS_DEV_MODEL_LEN = 32;// 设备型号最大长度
        public const int IVS_MRU_CODE_LEN = 64;//MRU分配方式
        public const int IVS_MAX_STREAM_LIST_NUM = 3;//码流信息列表最大3条
        public const int IVS_MAX_ENCODE_LIST_NUM = 2;//编码类型信息列表最大2条
        public const int IVS_MAX_RESOLUTION_LIST_NUM = 30;//分辨率列表最大30条
        public const int IVS_HOTKEY_CTRL = 0x01;
        public const int IVS_HOTKEY_SHIFT = 0x02;
        public const int IVS_HOTKEY_ALT = 0x04;
        public const int IVS_HOTKEY_WIN = 0x08;
        public const int IVS_VERSION_LEN = 32;// 客户端版本号长度
        public const int IVS_MD5_LEN = 32;// MD5值长度
        public const int IVS_TOKEN_LEN = 128;// MD5值长度
        public const int IVS_ABILITY_IA_FR = 0x01;// 智能分析-人脸
        public const int IVS_ABILITY_IA_BA = 0x02;// 智能分析-行为
        public const int IVS_ABILITY_IA_QD = 0x04;// 智能分析-质量诊断
        public const int IVS_MAX_RIGHT_GROUP_NAME_LEN = 64;// 权限组最大英文名长度（多语言由客户端自己映射实现）
        public const int IVS_MAX_RIGHT_GROUP_NUM = 8;// 权限组最大个数
        public const int IVS_MAX_ROLE_INFO_NUM = 128;// 最大角色个数
        public const int IVS_MAX_USER_GROUP_LEVEL = 4;// 用户组层级最大个数
        public const int IVS_MAX_USER_GROUP_DESC_LEN = 256;// 用户组备注
        public const int IVS_QUERY_VALUE_LEN = 2048;// 查询字段大小
        public const int IVS_MAX_CAMERA_PLAN_NUM = 64;// 摄像机最大计划种类数
        public const int IVS_MAX_TIMESPAN_NUM = 24;// 时间段最大数量
        public const int IVS_MAX_PLAN_INFO_NUM = 7;// 最大计划信息个数（一周7天）
        public const int IVS_MIN_TIME_SPLITTER_VALUE = 5;// 最小时间分割值，5分钟
        public const int IVS_MAX_TIME_SPLITTER_VALUE = 720;// 最大时间分割值，720分钟
        public const int IVS_MIN_SPACE_SPLITTER_VALUE = 50;// 最小容量分割值，50M
        public const int IVS_MAX_SPACE_SPLITTER_VALUE = 3072;// 最大容量分割值，3072M
        public const int IVS_MIN_RECORD_TIME = 300;// 最小录像时长，300，单位秒
        public const int IVS_MAX_RECORD_TIME = 43200;// 最大录像时长，43200，单位秒（12小时）
        public const int IVS_LOCAL_RECORD_PWD_LEN = 36;// 本地录像密码最大字节数，包含'\0'
        public const int IVS_MAX_PRERECORD_TIME = 300;// 最大预录时间，单位：秒
        public const int IVS_RECORD_TYPE_LEN = 8;// 录像类型长度
        public const int IVS_BOOKMARK_NAME_LEN = 612;
        public const int IVS_RECORD_LOCK_DESC_LEN = 260;
        public const int IVS_RECORD_PTZ_PRESET_NAME_LEN = 64;
        public const int IVS_MAX_VENDOR_TYPE_NAME_LEN = 32;// 厂商名称最大长度
        public const int IVS_DEVICE_NAME_LEN = 128;// 主设备名称长度
        public const int IVS_MAX_PROTOCOLTYPE_NAME_LEN = 64;// 协议类型描述最大长度
        public const int IVS_CAMERA_OSD_NUM_MAX = 128;
        public const int IVS_MAX_OSD_TEXT_LEN = 256;// OSD文字最大长字节数
        public const int IVS_MAX_MOTION_DETECTION_AREA_NUM = 8;// 运动检测区域个数
        public const int IVS_MAX_VIDEO_HIDE_AREA_NUM = 5;// 最大图像遮挡告警区域个数
        public const int IVS_MAX_VIDEO_HIDE_GUARD_TIME_NUM = 12;// 最大视频遮挡布防时间段个数
        public const int IVS_MAX_VIDEO_MASK_AREA_NUM = 5;// 最大隐私保护区域个数
        public const int IVS_ALARM_IN_NAME_LEN = 260;// 告警输入子设备名称长度
        public const int IVS_ALARM_OUT_NAME_LEN = 128;// 告警输出子设备名称长度
        public const int IVS_AUDIO_NAME_LEN = 128;// 音频子设备名称长度
        public const int IVS_AUDIO_CODE_LEN = 64;// 语音通道编码长度
        public const int IVS_MAX_CLUSTER_MEMBER_NUM = 16;// 集群最大数目
        public const int IVS_MAX_CLUSTER_NUM = 64;
        public const int IVS_MAX_DEV_GROUP_NUM = 5000;// 最大设备组数目
        public const int IVS_RESOLUTION_LEN = 16;// 分辨率字符串长度
        public const int IVS_MAX_STREAM_NUM = 8;
        public const int IVS_CAMERA_NAME_LEN = 192;// 摄像机名称长度
        public const int IVS_SERIAL_NAME_LEN = 128;// 串口设备名称长度
        public const int IVS_MAX_DEVICE_CHANNEL_NUM = 256;//  设备通道最大数目
        public const int IVS_CHANNEL_NAME_LEN = 128;//  通道名称长度
        public const int IVS_ALARM_DESCRIPTION_LEN = 1024;
        public const int IVS_ALARM_CODE_LEN = 64;
        public const int IVS_ALARM_NAME_LEN = 260;
        public const int IVS_NODE_TYPE_LEN = 8;
        public const int IVS_MAX_ALARM_LEVEL_NUM = 20;// 告警级别最大个数
        public const int IVS_ALARM_TYPE_CATEGORY_LEN = 8;
        public const int IVS_ALARM_EX_PARAM_LEN = 2048;// 告警上报扩展参数
        public const int IVS_ALARM_REPORT_ID_LEN = 32;// 告警上报ID
        public const int IVS_ALARM_TYPE_LEN = 64;// 告警类型长度
        public const int IVS_ALARM_LEVEL_COLOR_LEN = 16;
        public const int IVS_ALARM_CATEGORY_LEN = 8;
        public const int IVS_DEVICE_ALARM_LOCATION_INFO_LEN = 256;
        public const int IVS_NET_ELEMENT_ID_LEN = 32;
        public const int IVS_MAX_ALARM_TYPE_NUM = 32;// 最大告警类型个数
        public const int IVS_MAX_ALARM_IN_NUM = 512;// 最大防区个数
        public const int IVS_MAX_HELP_LEN = 40960;
        public const int IVS_LINKAGE_DEV_PARAM_LEN = 128;// 联动设备动作参数长度
        public const int IVS_LINKAGE_GLOBAL_PARAM_LEN = 1024;// 联动全局动作参数长度
        public const int IVS_MAX_LINKAGE_ACTION_DEVICE_NUM = 8;// 执行动作的设备最大个数
        public const int IVS_MAX_LINKAGE_ACTION_USER_NUM = 32;// 告警联动目标用户的最大个数
        public const int IVS_DICTIONARY_NAME_LEN = 64;// 字段名称长度
        public const int IVS_DICTIONARY_VALUE_LEN = 256;// 字典值长度
        public const int IVS_DICTIONARY_TYPE_LEN = 32;// 字典类型长度
        public const int IVS_DICTIONARY_REMARK_LEN = 256;// 备注长度
        public const int IVS_MAX_DOMAIN_ROUTE_NUM = 128;// 域路由最大记录数
        public const int IVS_MAX_PRESET_NUM = 256;// 预置位
        public const int IVS_PRESET_NAME_LEN = 84;// 预置位名称
        public const int IVS_MAX_CURISE_TRACK_NUM = 16;// 单个摄像机最大巡航轨迹个数
        public const int IVS_CURISE_TRACK_NAME_LEN = 84;// 轨迹名称
        public const int IVS_MAX_CURISE_TRACK_POINT = 20;// 巡航轨迹预置位最大个数
        public const int IVS_TVWALL_DECODER_CODE_LEN = 24;// 电视墙解码器长度
        public const int IVS_WATERMARK_ALARM_DESCRIPTION_LEN = 1024;
        public const int IVS_FTP_ACCOUNT_LEN = 64;// 名称长度
        public const int IVS_MAX_STREAM_USER_INFO_NUM = 512;//点播媒体流的用户信息最多512个
        public const int IVS_MAX_STREAM_CAM_INFO_NUM = 512;//单个用户正在调用的摄像机最多512个
    }
}
