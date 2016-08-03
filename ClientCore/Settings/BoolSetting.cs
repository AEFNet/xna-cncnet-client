﻿using Rampastring.Tools;

namespace ClientCore.Settings
{
    public class BoolSetting : INISetting<bool>
    {
        public BoolSetting(IniFile iniFile, string iniSection, string iniKey, bool defaultValue)
            : base(iniFile, iniSection, iniKey, defaultValue)
        {
        }

        public static implicit operator bool(BoolSetting bs)
        {
            return bs.Get();
        }

        protected override bool Get()
        {
            return IniFile.GetBooleanValue(IniSection, IniKey, DefaultValue);
        }

        protected override void Set(bool value)
        {
            IniFile.SetBooleanValue(IniSection, IniKey, value);
        }

        public override string ToString()
        {
            return Get().ToString();
        }
    }
}
