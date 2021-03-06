﻿public enum LanguageType
{
    English,
    Chinese,
}

/// <summary>
/// UIPanel类型
/// </summary>
public enum WindowType
{
    /// <summary>
    /// 未定义
    /// </summary>
    Undefine,
    /// <summary>
    /// 自由窗体
    /// </summary>
    FreeWindow,
    /// <summary>
    /// 固定窗体
    /// </summary>    
    FixedWindow,
    /// <summary>
    /// 弹窗
    /// </summary>
    MessageBox,
}

public enum CharacterType
{
    Hero,
    Monster,
}
public enum SoundType
{
    _3DSound,
    _2DSound,
}


public enum RangeCheckType
{
    Cycle,
    BoxCast,
    Sector,
    NoCheker
}


public enum WeaponType
{
    Axe,
    Arm,
}

public enum SlotPos
{
    leftHand,
    rightHand,
    leftFoot,
    rightFoot,
    back
}

public enum StrategyType
{
    LockBuildingStrategy,
    LockPlayerStrategy,
}


public enum EffectAttachType
{
    Follow_Origin,
    Follow_Overhead,
    Follow_Chest,
    Follow_Head,
    Start_At_CustomOrigin,
    World_Origin
}

public enum ModifierType
{
    /// <summary>
    /// 默认
    /// </summary>
    Default,
    /// <summary>
    /// 冰-火
    /// </summary>
    Ice_Fire,
    /// <summary>
    /// 生命-死亡
    /// </summary>
    Life_Death,
    /// <summary>
    /// 暗-光
    /// </summary>
    Dark_Optical,
}
