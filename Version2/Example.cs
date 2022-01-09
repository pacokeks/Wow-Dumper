﻿using Version2.Manager;

namespace Version2
{
    internal class ExampleTBC
    {
        internal static bool Load(Container C)
        {
            C.Classes = new List< _Class>
            {
                new _Class
                {
                    Name = "Player Stuff",
                    Offsets = new[]
                    {
                        new _Offset
                        {
                            Name = "Player Guid",
                            Pattern = "48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 83 BC 24 ?? ?? ?? ?? ?? 7C ?? 48 8B 8C 24 ?? ?? ?? ?? 48 8D 15 ?? ?? ?? ?? 45 33 C9 45 8D 41 ?? E8 ?? ?? ?? ?? 48 81 C4",
                            Position = 3
                        },
                        new _Offset
                        {
                            Name = "Player Name",
                            Pattern = "E8 ?? ?? ?? ?? 48 8D 4C 24 ?? 48 8B D8 E8 ?? ?? ?? ?? 4C 89 74 24",
                            Position = 1,
                            Levels = new []
                            {
                                new _Level
                                {
                                    Position = 5,
                                    MinusOne = true
                                }
                            }
                        }
                    }
                },
                new _Class
                {
                    Name = "Auto Loot",
                    Offsets = new[]
                    {
                        new _Offset
                        {
                            Name = "Base",
                            Pattern = "48 8B 05 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? 8B 58 ?? E8 ?? ?? ?? ??",
                            Position = 3,
                            Fields = new []
                            {
                                new _Field
                                {
                                    Type = ReadType.Byte,
                                    Name = "Offset",
                                    Position = 16
                                }
                            }
                        },
                    }
                },
                new _Class
                {
                    Name = "Camera",
                    Offsets = new[]
                    {
                        new _Offset
                        {
                            Name = "Base",
                            Pattern = "48 8B 05 ?? ?? ?? ?? 48 8B 88 ?? ?? ?? ?? 48 8B 43 ?? 48 39 81 ?? ?? ?? ??",
                            Position = 3,
                            Fields = new []
                            {
                                new _Field
                                {
                                    Type = ReadType.Word,
                                    Name = "Offset",
                                    Position = 10
                                }
                            }
                        }
                    }
                }
            };
            return C.Classes is { Count: > 0 };
        }
    }
}