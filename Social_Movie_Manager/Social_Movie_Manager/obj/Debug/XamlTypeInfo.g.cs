﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Social_Movie_Manager
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[16];
            _typeNameTable[0] = "Social_Movie_Manager.HorizontalScroll";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[2] = "Object";
            _typeNameTable[3] = "String";
            _typeNameTable[4] = "DrawerLayout.DrawerLayout";
            _typeNameTable[5] = "Windows.UI.Xaml.Controls.Grid";
            _typeNameTable[6] = "Windows.UI.Xaml.Controls.Panel";
            _typeNameTable[7] = "Boolean";
            _typeNameTable[8] = "Social_Movie_Manager.Slide_Menu";
            _typeNameTable[9] = "Social_Movie_Manager.Pages.AboutPage";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[11] = "Social_Movie_Manager.Pages.ExplorePage";
            _typeNameTable[12] = "Social_Movie_Manager.Pages.GroupsPage";
            _typeNameTable[13] = "Social_Movie_Manager.Pages.MainPage";
            _typeNameTable[14] = "Social_Movie_Manager.Pages.BlacklistPage";
            _typeNameTable[15] = "Social_Movie_Manager.Pages.WishlistPage";

            _typeTable = new global::System.Type[16];
            _typeTable[0] = typeof(global::Social_Movie_Manager.HorizontalScroll);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[2] = typeof(global::System.Object);
            _typeTable[3] = typeof(global::System.String);
            _typeTable[4] = typeof(global::DrawerLayout.DrawerLayout);
            _typeTable[5] = typeof(global::Windows.UI.Xaml.Controls.Grid);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Controls.Panel);
            _typeTable[7] = typeof(global::System.Boolean);
            _typeTable[8] = typeof(global::Social_Movie_Manager.Slide_Menu);
            _typeTable[9] = typeof(global::Social_Movie_Manager.Pages.AboutPage);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[11] = typeof(global::Social_Movie_Manager.Pages.ExplorePage);
            _typeTable[12] = typeof(global::Social_Movie_Manager.Pages.GroupsPage);
            _typeTable[13] = typeof(global::Social_Movie_Manager.Pages.MainPage);
            _typeTable[14] = typeof(global::Social_Movie_Manager.Pages.BlacklistPage);
            _typeTable[15] = typeof(global::Social_Movie_Manager.Pages.WishlistPage);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_HorizontalScroll() { return new global::Social_Movie_Manager.HorizontalScroll(); }
        private object Activate_4_DrawerLayout() { return new global::DrawerLayout.DrawerLayout(); }
        private object Activate_8_Slide_Menu() { return new global::Social_Movie_Manager.Slide_Menu(); }
        private object Activate_9_AboutPage() { return new global::Social_Movie_Manager.Pages.AboutPage(); }
        private object Activate_11_ExplorePage() { return new global::Social_Movie_Manager.Pages.ExplorePage(); }
        private object Activate_12_GroupsPage() { return new global::Social_Movie_Manager.Pages.GroupsPage(); }
        private object Activate_13_MainPage() { return new global::Social_Movie_Manager.Pages.MainPage(); }
        private object Activate_14_BlacklistPage() { return new global::Social_Movie_Manager.Pages.BlacklistPage(); }
        private object Activate_15_WishlistPage() { return new global::Social_Movie_Manager.Pages.WishlistPage(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Social_Movie_Manager.HorizontalScroll
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_0_HorizontalScroll;
                userType.AddMemberName("Button1Content");
                userType.AddMemberName("Button2Content");
                userType.AddMemberName("Button3Content");
                userType.AddMemberName("Button4Content");
                userType.AddMemberName("TextBlock1Content");
                userType.AddMemberName("TextBlock2Content");
                userType.AddMemberName("TextBlock3Content");
                userType.AddMemberName("TextBlock4Content");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Object
                xamlType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  String
                xamlType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  DrawerLayout.DrawerLayout
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Grid"));
                userType.Activator = Activate_4_DrawerLayout;
                userType.AddMemberName("IsDrawerOpen");
                xamlType = userType;
                break;

            case 5:   //  Windows.UI.Xaml.Controls.Grid
                xamlType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Windows.UI.Xaml.Controls.Panel
                xamlType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  Boolean
                xamlType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  Social_Movie_Manager.Slide_Menu
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_8_Slide_Menu;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Social_Movie_Manager.Pages.AboutPage
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_AboutPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  Social_Movie_Manager.Pages.ExplorePage
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_ExplorePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  Social_Movie_Manager.Pages.GroupsPage
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_GroupsPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  Social_Movie_Manager.Pages.MainPage
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  Social_Movie_Manager.Pages.BlacklistPage
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_BlacklistPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  Social_Movie_Manager.Pages.WishlistPage
                userType = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_WishlistPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_HorizontalScroll_Button1Content(object instance)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            return that.Button1Content;
        }
        private void set_0_HorizontalScroll_Button1Content(object instance, object Value)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            that.Button1Content = (global::System.Object)Value;
        }
        private object get_1_HorizontalScroll_Button2Content(object instance)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            return that.Button2Content;
        }
        private void set_1_HorizontalScroll_Button2Content(object instance, object Value)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            that.Button2Content = (global::System.Object)Value;
        }
        private object get_2_HorizontalScroll_Button3Content(object instance)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            return that.Button3Content;
        }
        private void set_2_HorizontalScroll_Button3Content(object instance, object Value)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            that.Button3Content = (global::System.Object)Value;
        }
        private object get_3_HorizontalScroll_Button4Content(object instance)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            return that.Button4Content;
        }
        private void set_3_HorizontalScroll_Button4Content(object instance, object Value)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            that.Button4Content = (global::System.Object)Value;
        }
        private object get_4_HorizontalScroll_TextBlock1Content(object instance)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            return that.TextBlock1Content;
        }
        private void set_4_HorizontalScroll_TextBlock1Content(object instance, object Value)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            that.TextBlock1Content = (global::System.String)Value;
        }
        private object get_5_HorizontalScroll_TextBlock2Content(object instance)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            return that.TextBlock2Content;
        }
        private void set_5_HorizontalScroll_TextBlock2Content(object instance, object Value)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            that.TextBlock2Content = (global::System.String)Value;
        }
        private object get_6_HorizontalScroll_TextBlock3Content(object instance)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            return that.TextBlock3Content;
        }
        private void set_6_HorizontalScroll_TextBlock3Content(object instance, object Value)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            that.TextBlock3Content = (global::System.String)Value;
        }
        private object get_7_HorizontalScroll_TextBlock4Content(object instance)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            return that.TextBlock4Content;
        }
        private void set_7_HorizontalScroll_TextBlock4Content(object instance, object Value)
        {
            var that = (global::Social_Movie_Manager.HorizontalScroll)instance;
            that.TextBlock4Content = (global::System.String)Value;
        }
        private object get_8_DrawerLayout_IsDrawerOpen(object instance)
        {
            var that = (global::DrawerLayout.DrawerLayout)instance;
            return that.IsDrawerOpen;
        }
        private void set_8_DrawerLayout_IsDrawerOpen(object instance, object Value)
        {
            var that = (global::DrawerLayout.DrawerLayout)instance;
            that.IsDrawerOpen = (global::System.Boolean)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember xamlMember = null;
            global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Social_Movie_Manager.HorizontalScroll.Button1Content":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Social_Movie_Manager.HorizontalScroll");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "Button1Content", "Object");
                xamlMember.Getter = get_0_HorizontalScroll_Button1Content;
                xamlMember.Setter = set_0_HorizontalScroll_Button1Content;
                break;
            case "Social_Movie_Manager.HorizontalScroll.Button2Content":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Social_Movie_Manager.HorizontalScroll");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "Button2Content", "Object");
                xamlMember.Getter = get_1_HorizontalScroll_Button2Content;
                xamlMember.Setter = set_1_HorizontalScroll_Button2Content;
                break;
            case "Social_Movie_Manager.HorizontalScroll.Button3Content":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Social_Movie_Manager.HorizontalScroll");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "Button3Content", "Object");
                xamlMember.Getter = get_2_HorizontalScroll_Button3Content;
                xamlMember.Setter = set_2_HorizontalScroll_Button3Content;
                break;
            case "Social_Movie_Manager.HorizontalScroll.Button4Content":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Social_Movie_Manager.HorizontalScroll");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "Button4Content", "Object");
                xamlMember.Getter = get_3_HorizontalScroll_Button4Content;
                xamlMember.Setter = set_3_HorizontalScroll_Button4Content;
                break;
            case "Social_Movie_Manager.HorizontalScroll.TextBlock1Content":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Social_Movie_Manager.HorizontalScroll");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "TextBlock1Content", "String");
                xamlMember.Getter = get_4_HorizontalScroll_TextBlock1Content;
                xamlMember.Setter = set_4_HorizontalScroll_TextBlock1Content;
                break;
            case "Social_Movie_Manager.HorizontalScroll.TextBlock2Content":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Social_Movie_Manager.HorizontalScroll");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "TextBlock2Content", "String");
                xamlMember.Getter = get_5_HorizontalScroll_TextBlock2Content;
                xamlMember.Setter = set_5_HorizontalScroll_TextBlock2Content;
                break;
            case "Social_Movie_Manager.HorizontalScroll.TextBlock3Content":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Social_Movie_Manager.HorizontalScroll");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "TextBlock3Content", "String");
                xamlMember.Getter = get_6_HorizontalScroll_TextBlock3Content;
                xamlMember.Setter = set_6_HorizontalScroll_TextBlock3Content;
                break;
            case "Social_Movie_Manager.HorizontalScroll.TextBlock4Content":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Social_Movie_Manager.HorizontalScroll");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "TextBlock4Content", "String");
                xamlMember.Getter = get_7_HorizontalScroll_TextBlock4Content;
                xamlMember.Setter = set_7_HorizontalScroll_TextBlock4Content;
                break;
            case "DrawerLayout.DrawerLayout.IsDrawerOpen":
                userType = (global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("DrawerLayout.DrawerLayout");
                xamlMember = new global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlMember(this, "IsDrawerOpen", "Boolean");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_8_DrawerLayout_IsDrawerOpen;
                xamlMember.Setter = set_8_DrawerLayout_IsDrawerOpen;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlSystemBaseType
    {
        global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Social_Movie_Manager.Social_Movie_Manager_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


