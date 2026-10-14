using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Native_Coding_Agent_Hava_Durumu.ObjectRepository
{
    public static class Descriptors
    {
        public static class __TODO_Indicate___Google_Chrome_uygulamasını_aç
        {
            static string _reference = "-PT3USTR-UKEeEqjrK4Mgw/r1Ke6Skk-Eqzuow2fVpOCw";
            public static _Implementation.___TODO_Indicate___Google_Chrome_uygulamasını_aç.__TODO_Indicate___Google_Chrome_uygulamasını_aç TODO_Indicate___Google_Chrome_uygulamasını_aç { get; private set; } = new _Implementation.___TODO_Indicate___Google_Chrome_uygulamasını_aç.__TODO_Indicate___Google_Chrome_uygulamasını_aç();
        }
    }
}

namespace Native_Coding_Agent_Hava_Durumu._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace ___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç
    {
        public class __TODO_Indicate___Ara_butonuna_tıkla : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __TODO_Indicate___Ara_butonuna_tıkla(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "-PT3USTR-UKEeEqjrK4Mgw/Gy1q2W7sp0i5mKL0Vk9qaA",
                    DisplayName = "TODO Indicate — Ara butonuna tıkla",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç
    {
        public class __TODO_Indicate___Google_arama_kutusuna_yaz : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __TODO_Indicate___Google_arama_kutusuna_yaz(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "-PT3USTR-UKEeEqjrK4Mgw/lw6B7iO0rkekR3AQLq7gLw",
                    DisplayName = "TODO Indicate — Google arama kutusuna yaz",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç
    {
        public class __TODO_Indicate___Hava_durumu_derecesini_oku : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __TODO_Indicate___Hava_durumu_derecesini_oku(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "-PT3USTR-UKEeEqjrK4Mgw/iXZHR3z__UqnWnHjD6XvoA",
                    DisplayName = "TODO Indicate — Hava durumu derecesini oku",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___TODO_Indicate___Google_Chrome_uygulamasını_aç
    {
        public class __TODO_Indicate___Google_Chrome_uygulamasını_aç : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __TODO_Indicate___Google_Chrome_uygulamasını_aç()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "-PT3USTR-UKEeEqjrK4Mgw/qBOGdhY4CE68OrMyjwy2gQ",
                    DisplayName = "TODO Indicate — Google Chrome uygulamasını aç",
                    Screen = this
                };
                TODO_Indicate___Ara_butonuna_tıkla = new _Implementation.___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç.__TODO_Indicate___Ara_butonuna_tıkla(this, null);
                TODO_Indicate___Google_arama_kutusuna_yaz = new _Implementation.___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç.__TODO_Indicate___Google_arama_kutusuna_yaz(this, null);
                TODO_Indicate___Hava_durumu_derecesini_oku = new _Implementation.___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç.__TODO_Indicate___Hava_durumu_derecesini_oku(this, null);
            }

            public _Implementation.___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç.__TODO_Indicate___Ara_butonuna_tıkla TODO_Indicate___Ara_butonuna_tıkla { get; private set; }
            public _Implementation.___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç.__TODO_Indicate___Google_arama_kutusuna_yaz TODO_Indicate___Google_arama_kutusuna_yaz { get; private set; }
            public _Implementation.___TODO_Indicate___Google_Chrome_uygulamasını_aç._TODO_Indicate___Google_Chrome_uygulamasını_aç.__TODO_Indicate___Hava_durumu_derecesini_oku TODO_Indicate___Hava_durumu_derecesini_oku { get; private set; }
        }
    }
}