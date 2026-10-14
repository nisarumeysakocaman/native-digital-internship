using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Data_hw.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Chrome_Google_Çeviri
        {
            static string _reference = "vKvKuUAn3EqLuxMjXQeHKw/muvslVzvmkmZ-OzZXy1NYg";
            public static _Implementation.___Chrome_Google_Çeviri.__Chrome_Google_Çeviri Chrome_Google_Çeviri { get; private set; } = new _Implementation.___Chrome_Google_Çeviri.__Chrome_Google_Çeviri();
        }
    }
}

namespace Data_hw._Implementation
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

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __apple : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __apple(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/8nnqq1ZkfkqpEZCe6EHlEw",
                    DisplayName = "apple",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __Click__Rusça_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Rusça_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/fCNG5S-0e0ioVqf6LXypLQ",
                    DisplayName = "Click 'Rusça'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __Click__Türkçe__İngilizce_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Türkçe__İngilizce_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/JTliOEkW80GtYoJDB3BKeg",
                    DisplayName = "Click 'Türkçe  İngilizce'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __Çeviri : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Çeviri(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/QK43-hW_QkudN2aZ5t77Aw",
                    DisplayName = "Çeviri",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __Rusça : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Rusça(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/yF7qbQgpcUeyaVuOzxFW6A",
                    DisplayName = "Rusça",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __svg : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __svg(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/DEvat5TemEe0pd_nrRSE2w",
                    DisplayName = "svg",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __TEXTAREA : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __TEXTAREA(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/_mMy4Zyv9ECyfr07OqwVVA",
                    DisplayName = "TEXTAREA",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __TEXTAREA_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __TEXTAREA_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/Otl2D60wJ0y_NoTpzjSFQQ",
                    DisplayName = "TEXTAREA(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __Türkçe__İngilizce : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Türkçe__İngilizce(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/lL8Hbmllvk2pUGvlmZ8plg",
                    DisplayName = "Türkçe  İngilizce",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __Type_Into_kelimeyi_çevirme : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Type_Into_kelimeyi_çevirme(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/4KYDxVGEI0eL71YH2umu_g",
                    DisplayName = "Type Into kelimeyi çevirme",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri._Chrome_Google_Çeviri
    {
        public class __яблокояблокоAlternatifl_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __яблокояблокоAlternatifl_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/fza49IKzpUGzLCgf6CgEEw",
                    DisplayName = "яблокояблокоAlternatifl…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Google_Çeviri
    {
        public class __Chrome_Google_Çeviri : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Google_Çeviri()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "vKvKuUAn3EqLuxMjXQeHKw/r9o2BkkmNUqozwuxqpDyKA",
                    DisplayName = "Chrome Google Çeviri",
                    Screen = this
                };
                apple = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__apple(this, null);
                Click__Rusça_ = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Click__Rusça_(this, null);
                Click__Türkçe__İngilizce_ = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Click__Türkçe__İngilizce_(this, null);
                Çeviri = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Çeviri(this, null);
                Rusça = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Rusça(this, null);
                svg = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__svg(this, null);
                TEXTAREA = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__TEXTAREA(this, null);
                TEXTAREA_1_ = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__TEXTAREA_1_(this, null);
                Türkçe__İngilizce = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Türkçe__İngilizce(this, null);
                Type_Into_kelimeyi_çevirme = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Type_Into_kelimeyi_çevirme(this, null);
                яблокояблокоAlternatifl_ = new _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__яблокояблокоAlternatifl_(this, null);
            }

            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__apple apple { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Click__Rusça_ Click__Rusça_ { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Click__Türkçe__İngilizce_ Click__Türkçe__İngilizce_ { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Çeviri Çeviri { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Rusça Rusça { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__svg svg { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__TEXTAREA TEXTAREA { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__TEXTAREA_1_ TEXTAREA_1_ { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Türkçe__İngilizce Türkçe__İngilizce { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__Type_Into_kelimeyi_çevirme Type_Into_kelimeyi_çevirme { get; private set; }
            public _Implementation.___Chrome_Google_Çeviri._Chrome_Google_Çeviri.__яблокояблокоAlternatifl_ яблокояблокоAlternatifl_ { get; private set; }
        }
    }
}