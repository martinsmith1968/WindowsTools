﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickCalendar.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Calendar_ShowToday {
            get {
                return ((bool)(this["Calendar_ShowToday"]));
            }
            set {
                this["Calendar_ShowToday"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Calendar_ShowTodayCircle {
            get {
                return ((bool)(this["Calendar_ShowTodayCircle"]));
            }
            set {
                this["Calendar_ShowTodayCircle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Calendar_ShowWeekNumbers {
            get {
                return ((bool)(this["Calendar_ShowWeekNumbers"]));
            }
            set {
                this["Calendar_ShowWeekNumbers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public global::System.Windows.Forms.Day Calendar_FirstDayOfWeek {
            get {
                return ((global::System.Windows.Forms.Day)(this["Calendar_FirstDayOfWeek"]));
            }
            set {
                this["Calendar_FirstDayOfWeek"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point Main_Location {
            get {
                return ((global::System.Drawing.Point)(this["Main_Location"]));
            }
            set {
                this["Main_Location"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Size Main_Size {
            get {
                return ((global::System.Drawing.Size)(this["Main_Size"]));
            }
            set {
                this["Main_Size"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool App_UpgradePending {
            get {
                return ((bool)(this["App_UpgradePending"]));
            }
            set {
                this["App_UpgradePending"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool YearViewStartsWithFirstMonth {
            get {
                return ((bool)(this["YearViewStartsWithFirstMonth"]));
            }
            set {
                this["YearViewStartsWithFirstMonth"] = value;
            }
        }
    }
}
