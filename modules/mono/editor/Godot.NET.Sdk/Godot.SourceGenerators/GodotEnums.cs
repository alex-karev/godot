using System;

namespace Godot.SourceGenerators
{
    // TODO: May need to think about compatibility here. Could Godot change these values between minor versions?

    internal enum VariantType
    {
        Nil = 0,
        Bool = 1,
        Int = 2,
        Float = 3,
        String = 4,
        Vector2 = 5,
        Vector2i = 6,
        Rect2 = 7,
        Rect2i = 8,
        Vector3 = 9,
        Vector3i = 10,
        Transform2d = 11,
        Vector4 = 12,
        Vector4i = 13,
        Plane = 14,
        Quaternion = 15,
        Aabb = 16,
        Basis = 17,
        Transform3d = 18,
        Projection = 19,
        Color = 20,
        StringName = 21,
        NodePath = 22,
        Rid = 23,
        Object = 24,
        Callable = 25,
        Signal = 26,
        Dictionary = 27,
        Array = 28,
        PackedByteArray = 29,
        PackedInt32Array = 30,
        PackedInt64Array = 31,
        PackedFloat32Array = 32,
        PackedFloat64Array = 33,
        PackedStringArray = 34,
        PackedVector2Array = 35,
        PackedVector3Array = 36,
        PackedColorArray = 37,
        Max = 38
    }

    internal enum PropertyHint
    {
        None = 0,
        Range = 1,
        Enum = 2,
        EnumSuggestion = 3,
        ExpEasing = 4,
        Link = 5,
        Flags = 6,
        Layers2dRender = 7,
        Layers2dPhysics = 8,
        Layers2dNavigation = 9,
        Layers3dRender = 10,
        Layers3dPhysics = 11,
        Layers3dNavigation = 12,
        File = 13,
        Dir = 14,
        GlobalFile = 15,
        GlobalDir = 16,
        ResourceType = 17,
        MultilineText = 18,
        Expression = 19,
        PlaceholderText = 20,
        ColorNoAlpha = 21,
        ObjectId = 22,
        TypeString = 23,
        NodePathToEditedNode = 24,
        ObjectTooBig = 25,
        NodePathValidTypes = 26,
        SaveFile = 27,
        GlobalSaveFile = 28,
        IntIsObjectid = 29,
        IntIsPointer = 30,
        ArrayType = 31,
        LocaleId = 32,
        LocalizableString = 33,
        NodeType = 34,
        HideQuaternionEdit = 35,
        Password = 36,
        Max = 37
    }

    [Flags]
    internal enum PropertyUsageFlags
    {
        None = 0,
        Storage = 2,
        Editor = 4,
        Internal = 8,
        Checkable = 16,
        Checked = 32,
        Group = 64,
        Category = 128,
        Subgroup = 256,
        ClassIsBitfield = 512,
        NoInstanceState = 1024,
        RestartIfChanged = 2048,
        ScriptVariable = 4096,
        StoreIfNull = 8192,
        UpdateAllIfModified = 16384,
        ScriptDefaultValue = 32768,
        ClassIsEnum = 65536,
        NilIsVariant = 131072,
        Array = 262144,
        DoNotShareOnDuplicate = 524288,
        HighEndGfx = 1048576,
        NodePathFromSceneRoot = 2097152,
        ResourceNotPersistent = 4194304,
        KeyingIncrements = 8388608,
        DeferredSetResource = 16777216,
        EditorInstantiateObject = 33554432,
        EditorBasicSetting = 67108864,
        ReadOnly = 134217728,
        Default = 6,
        NoEditor = 2
    }

    [Flags]
    public enum MethodFlags
    {
        Normal = 1,
        Editor = 2,
        Const = 4,
        Virtual = 8,
        Vararg = 16,
        Static = 32,
        ObjectCore = 64,
        Default = 1
    }
}
