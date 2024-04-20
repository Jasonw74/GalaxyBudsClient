﻿// ReSharper disable InconsistentNaming

using GalaxyBudsClient.Generated.Model.Attributes;

namespace GalaxyBudsClient.Message;

/// <summary>
/// SPP message ids that have been reused or replaced by other message ids, but are still important for compatibility reasons.
/// </summary>
public enum LegacyMsgIds
{
    SPP_ROLE_STATE = 115,
    AMBIENT_VOICE_FOCUS = 133
}

/// <summary>
/// SPP message ids
/// </summary>
/// <remarks>
/// Enum member annotations: <br/>
///     UNKNOWN_ - Unknown ID <br/>
///     UNK_ - Undocumented ID with guessed name/meaning (see also https://github.com/ThePBone/GalaxyBudsClient/blob/master/GalaxyBudsPlus_HiddenDebugFeatures.md) <br/>
/// All other member names are based on decompilations of the official Samsung app. 
/// </remarks>
[CompiledEnum]
public enum MsgIds
{
    UNKNOWN_0 = 0,
    UNK_SPP_ALT = 1,
    UNKNOWN_2 = 2,
    UNKNOWN_3 = 3,
    UNKNOWN_4 = 4,
    UNKNOWN_5 = 5,
    UNKNOWN_6 = 6,
    UNKNOWN_7 = 7,
    UNKNOWN_8 = 8,
    UNKNOWN_9 = 9,
    UNKNOWN_10 = 10,
    UNKNOWN_11 = 11,
    UNKNOWN_12 = 12,
    UNKNOWN_13 = 13,
    UNKNOWN_14 = 14,
    UNKNOWN_15 = 15,
    SET_MODE_CHANGE = 16,
    GET_MODE = 17,
    HIDDEN_CMD_MODE = 18,
    HIDDEN_CMD_DATA = 19,
    UNKNOWN_20 = 20,
    UNKNOWN_21 = 21,
    UNKNOWN_22 = 22,
    UNKNOWN_23 = 23,
    UNKNOWN_24 = 24,
    UNKNOWN_25 = 25,
    UNKNOWN_26 = 26,
    UNKNOWN_27 = 27,
    UNKNOWN_28 = 28,
    UNKNOWN_29 = 29,
    UNKNOWN_30 = 30,
    UNKNOWN_31 = 31,
    SET_DEBUG_MODE = 32,
    DEBUG_MODE_LOG = 33,
    DEBUG_SKU = 34,
    DEBUG_GET_PE_RSSI = 35,
    DEBUG_GET_VERSION = 36,
    UNKNOWN_37 = 37,
    DEBUG_GET_ALL_DATA = 38,
    UNK_DISCONNECT = 39,
    DEBUG_BUILD_INFO = 40,
    DEBUG_SERIAL_NUMBER = 41,
    UNKNOWN_42 = 42,
    UNKNOWN_43 = 43,
    UNKNOWN_44 = 44,
    TOUCH_ON_BUDS = 45,
    UNKNOWN_46 = 46,
    UNKNOWN_47 = 47,
    LOG_COREDUMP_COMMIT_SUICIDE = 48,
    LOG_COREDUMP_DATA_SIZE = 49,
    LOG_COREDUMP_DATA = 50,
    LOG_COREDUMP_COMPLETE = 51,
    LOG_TRACE_START = 52,
    LOG_TRACE_DATA = 53,
    LOG_TRACE_COMPLETE = 54,
    LOG_TRACE_ROLE_SWITCH = 55,
    LOG_COREDUMP_DATA_DONE = 56,
    LOG_TRACE_DATA_DONE = 57,
    LOG_SESSION_OPEN = 58,
    LOG_SESSION_CLOSE = 59,
    UNKNOWN_60 = 60,
    UNKNOWN_61 = 61,
    UNKNOWN_62 = 62,
    UNKNOWN_63 = 63,
    USAGE_REPORT = 64,
    METERING_REPORT = 65,
    UNIVERSAL_MSG_ID_ACKNOWLEDGEMENT = 66,
    WRITE_PROPERTY = 67, //alt mode
    READ_PROPERTY = 68, //alt mode
    NOTIFY_PROPERTY = 69, //alt mode
    UNKNOWN_70 = 70,
    USAGE_REPORT_V2 = 71,
    EXTRA_CLEAR_SOUND_CALL = 72,
    UNKNOWN_73 = 73,
    AGING_TEST_REPORT = 74,
    ACT_TEST_CMD = 75,
    UNKNOWN_76 = 76,
    UNKNOWN_77 = 77,
    UNKNOWN_78 = 78,
    UNKNOWN_79 = 79,
    RESET = 80,
    RESP = 81,
    UNK_CRASH = 82,
    UNK_SHUTDOWN = 83,
    UNKNOWN_84 = 84,
    UNKNOWN_85 = 85,
    UNK_RF_TEST = 86,
    UNKNOWN_87 = 87,
    UNKNOWN_88 = 88,
    UNKNOWN_89 = 89,
    UNKNOWN_90 = 90,
    UNKNOWN_91 = 91,
    UNKNOWN_92 = 92,
    UNKNOWN_93 = 93,
    UNKNOWN_94 = 94,
    UNKNOWN_95 = 95,
    STATUS_UPDATED = 96,
    EXTENDED_STATUS_UPDATED = 97,
    CONNECTION_UPDATED = 98,
    VERSION_INFO = 99,
    SET_DETECT_SOUND = 100,
    UNKNOWN_101 = 101,
    SET_BIXBY_KEYWORD = 102,
    SET_HEARING_TEST_RESULT = 103,
    VERSION_INFO_LONG = 104,
    UNKNOWN_105 = 105,
    UNKNOWN_106 = 106,
    UNKNOWN_107 = 107,
    PAUSE_MEDIA_WHEN_ONE_BUD_REMOVED = 108,
    AMBIENT_DURING_CALL_NOTI = 109,
    SET_CALL_PATH_CONTROL = 110,
    SET_ANC_WITH_ONE_EARBUD = 111,
    MAIN_CHANGE = 112,
    PROFILE_CONTROL = 113,
    UNK_PAIRING_MODE = 114,
    AUTO_SWITCH_AUDIO_OUTPUT = 115, /* prior: SPP_ROLE_STATE */
    UNKNOWN_116 = 116,
    UNKNOWN_117 = 117,
    MULTIPOINT_INFO = 118,
    NOISE_CONTROLS_UPDATE = 119,
    NOISE_CONTROLS = 120,
    SET_TOUCH_AND_HOLD_NOISE_CONTROLS = 121,
    SET_DETECT_CONVERSATIONS = 122,
    SET_DETECT_CONVERSATIONS_DURATION = 123,
    SET_SPATIAL_AUDIO = 124,
    SET_SPEAK_SEAMLESSLY = 125,
    SET_AMPLIFY_AMBIENT_SOUND = 126,
    UNKNOWN_127 = 127,
    SET_AMBIENT_MODE = 128,
    AMBIENT_MODE_UPDATED = 129, 
    CUSTOMIZE_AMBIENT_SOUND = 130, /* prior: SET_A2DP_VOL */
    NOISE_REDUCTION_LEVEL = 131,  /* prior: A2DP_VOLUME_UPDATED */
    AMBIENT_VOLUME = 132,
    ADJUST_SOUND_SYNC = 133, /* prior: AMBIENT_VOICE_FOCUS */
    EQUALIZER = 134,
    GAME_MODE = 135,
    MANAGER_INFO = 136,
    AMBIENT_WEARING_STATUS_UPDATED = 137,
    SET_IN_BAND_RINGTONE = 138,
    SET_SIDETONE = 139,
    UNKNOWN_140 = 140,
    TAP_TEST_MODE = 141,
    TAP_TEST_MODE_EVENT = 142,
    SET_HEARING_ENHANCEMENTS = 143,
    LOCK_TOUCHPAD = 144,
    TOUCH_UPDATED = 145,
    SET_TOUCHPAD_OPTION = 146,
    SET_TOUCHPAD_OTHER_OPTION = 147,
    BATTERY_TYPE = 148,
    OUTSIDE_DOUBLE_TAP = 149,
    EXTRA_HIGH_AMBIENT = 150,
    SET_VOICE_WAKE_UP = 151,
    SET_NOISE_REDUCTION = 152,
    VOICE_WAKE_UP_LANGUAGE = 153,
    VOICE_WAKE_UP_EVENT = 154,
    NOISE_REDUCTION_MODE_UPDATE = 155,
    VOICE_WAKE_UP_LISTENING_STATUS = 156,
    CHECK_THE_FIT_OF_EARBUDS = 157,
    CHECK_THE_FIT_OF_EARBUDS_RESULT = 158,
    PASS_THROUGH = 159,
    FIND_MY_EARBUDS_START = 160,
    FIND_MY_EARBUDS_STOP = 161,
    MUTE_EARBUD = 162,
    MUTE_EARBUD_STATUS_UPDATED = 163,
    VOICE_NOTI_STATUS = 164,
    VOICE_NOTI_STOP = 165,
    FIND_MY_EARBUDS_ON_WEARING_START = 166, // previously: NOTIFICATION_INFO
    UPDATE_TIME = 167,
    START_VOICE_RECORD = 168,
    UNK_CONN_INFO = 169,
    UNKNOWN_170 = 170,
    SELF_TEST = 171,
    SET_FMM_CONFIG = 172,
    GET_FMM_CONFIG = 173,
    UNKNOWN_174 = 174,
    SET_SEAMLESS_CONNECTION = 175,
    FOTA_V1_SESSION = 176,
    FOTA_V1_CONTROL = 177,
    FOTA_V1_DOWNLOAD_DATA = 178,
    FOTA_V1_UPDATED = 179,
    FOTA_DEVICE_INFO_SW_VERSION = 180,
    FOTA_BACKGROUND_NEED = 181, // previously: FOTA_V1_ABORT
    FOTA_BACKGROUND_READY = 182, // previously: UNK_DEBUG_INFO_1
    FOTA_CHANGE_HALL_IC_STATUS = 183,
    UNKNOWN_184 = 184,
    FOTA_RESULT = 185,
    FOTA_EMERGENCY = 186,
    FOTA_OPEN = 187,
    FOTA_CONTROL = 188,
    FOTA_DOWNLOAD_DATA = 189,
    FOTA_UPDATE = 190,
    UNKNOWN_191 = 191,
    UPDATE_VOICE_CMD = 192,
    SET_VOICE_CMD = 193,
    SPATIAL_AUDIO_DATA = 194,
    SPATIAL_AUDIO_CONTROL = 195,
    UNKNOWN_196 = 196,
    UNKNOWN_197 = 197,
    NECK_POSTURE_CALI_DATA = 198,
    NECK_POSTURE_CONTROL = 199,
    NECK_POSTURE_PHONE_DATA = 200,
    NECK_POSTURE_SET = 201,
    UNKNOWN_202 = 202,
    UNKNOWN_203 = 203,
    UNKNOWN_204 = 204,
    CRADLE_SERIAL_NUMBER = 205,
    SOC_BATTERY_CYCLE = 206,
    UNKNOWN_207 = 207,
    UNKNOWN_208 = 208,
    UNKNOWN_209 = 209,
    UNKNOWN_210 = 210,
    GET_PERSONAL_NAME = 211,
    UNK_DUMP_BONDED_DEVICES = 212,
    UNKNOWN_213 = 213,
    UNK_BONDED_DEVICES = 214,
    UNKNOWN_215 = 215,
    UNKNOWN_216 = 216,
    UNKNOWN_217 = 217,
    ADAPTIVE_EQ_CONTROL = 218,
    ADAPTIVE_EQ_STATUS = 219,
    UNKNOWN_220 = 220,
    UNKNOWN_221 = 221,
    UNKNOWN_222 = 222,
    UNKNOWN_223 = 223,
    UNKNOWN_224 = 224,
    UNKNOWN_225 = 225,
    UNKNOWN_226 = 226,
    UNKNOWN_227 = 227,
    UNKNOWN_228 = 228,
    UNKNOWN_229 = 229,
    UNKNOWN_230 = 230,
    UNKNOWN_231 = 231,
    UNKNOWN_232 = 232,
    SD_SPEAKER_RES = 233,
    SD_MIC_RES = 234,
    UNKNOWN_235 = 235,
    UNKNOWN_236 = 236,
    UNKNOWN_237 = 237,
    UNKNOWN_238 = 238,
    UNKNOWN_239 = 239,
    UNKNOWN_240 = 240,
    UNK_CRASH_REPORT = 241,
    UNK_GENERIC_EVENT = 242,
    UNKNOWN_243 = 243,
    UNKNOWN_244 = 244,
    UNKNOWN_245 = 245,
    UNKNOWN_246 = 246,
    UNKNOWN_247 = 247,
    UNKNOWN_248 = 248,
    UNKNOWN_249 = 249,
    SD_BATTERY_STATUS = 250,
    SD_CABLE_CHARGING = 251,
    SD_WIRELESS_CHARGING = 252,
    UNKNOWN_253 = 253,
    SD_TOUCH_RES = 254,
    SET_TOUCH_TYPE = 255
}

public enum MsgConstants
{
    LegacySom = 0xFE,
    LegacyEom = 0xEE,
    Som = 0xFD,
    Eom = 0xDD
}

[CompiledEnum]
public enum MsgTypes
{
    Request = 0,
    Response = 1
}