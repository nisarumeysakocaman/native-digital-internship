using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Native_Staj_UiAutomation_Excel.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Chrome_karaman_hava_durumu___Google_da_Ara
        {
            static string _reference = "WYLQ-Vi2SUmhLXtd9HrMyg/bvbebTQLH0yExCzsO_CfnQ";
            public static _Implementation.___Chrome_karaman_hava_durumu___Google_da_Ara.__Chrome_karaman_hava_durumu___Google_da_Ara Chrome_karaman_hava_durumu___Google_da_Ara { get; private set; } = new _Implementation.___Chrome_karaman_hava_durumu___Google_da_Ara.__Chrome_karaman_hava_durumu___Google_da_Ara();
        }

        public static class __Chrome_Rpa_Challenge
        {
            static string _reference = "WYLQ-Vi2SUmhLXtd9HrMyg/n_hqZ0q390CX-5gp8ADfDg";
            public static _Implementation.___Chrome_Rpa_Challenge.__Chrome_Rpa_Challenge Chrome_Rpa_Challenge { get; private set; } = new _Implementation.___Chrome_Rpa_Challenge.__Chrome_Rpa_Challenge();
            public static _Implementation.___Chrome_Rpa_Challenge.__Chrome_Rpa_Challenge_1_ Chrome_Rpa_Challenge_1_ { get; private set; } = new _Implementation.___Chrome_Rpa_Challenge.__Chrome_Rpa_Challenge_1_();
            public static _Implementation.___Chrome_Rpa_Challenge.__Chrome_Rpa_Challenge_2_ Chrome_Rpa_Challenge_2_ { get; private set; } = new _Implementation.___Chrome_Rpa_Challenge.__Chrome_Rpa_Challenge_2_();
        }

        public static class Chrome_Satılık__Kiralık_Emlak_İlanları_sahibinden_com_da
        {
            static string _reference = "WYLQ-Vi2SUmhLXtd9HrMyg/PcOHRm2HsEy72Y1Li-oL7A";
            public static _Implementation._Chrome_Satılık__Kiralık_Emlak_İlanları_sahibinden_com_da.__Chrome_Satılık__Kiralık_Emlak_İlanları_sahibi Chrome_Satılık__Kiralık_Emlak_İlanları_sahibi { get; private set; } = new _Implementation._Chrome_Satılık__Kiralık_Emlak_İlanları_sahibinden_com_da.__Chrome_Satılık__Kiralık_Emlak_İlanları_sahibi();
        }
    }
}

namespace Native_Staj_UiAutomation_Excel._Implementation
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

    namespace ___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara
    {
        public class ___28 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___28(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/9BxUD2XdYka4z7StNYphzg",
                    DisplayName = "28",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara
    {
        public class __Hava_durumu : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Hava_durumu(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/9p4sCewkX0qijmxwNBjQrQ",
                    DisplayName = "Hava durumu",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara
    {
        public class __Hava_durumu_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Hava_durumu_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/MbfiPsGtw0qchfJgg1yUYA",
                    DisplayName = "Hava durumu(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_karaman_hava_durumu___Google_da_Ara
    {
        public class __Chrome_karaman_hava_durumu___Google_da_Ara : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_karaman_hava_durumu___Google_da_Ara()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/abTVYntLcUCvCzLgMN72xw",
                    DisplayName = "Chrome karaman hava durumu - Google'da Ara",
                    Screen = this
                };
                _28 = new _Implementation.___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara.___28(this, null);
                Hava_durumu = new _Implementation.___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara.__Hava_durumu(this, null);
                Hava_durumu_1_ = new _Implementation.___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara.__Hava_durumu_1_(this, null);
            }

            public _Implementation.___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara.___28 _28 { get; private set; }
            public _Implementation.___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara.__Hava_durumu Hava_durumu { get; private set; }
            public _Implementation.___Chrome_karaman_hava_durumu___Google_da_Ara._Chrome_karaman_hava_durumu___Google_da_Ara.__Hava_durumu_1_ Hava_durumu_1_ { get; private set; }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge
    {
        public class __Click__Movie_Search_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Movie_Search_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/CeFe3TipjUmS7FraOHv5FA",
                    DisplayName = "Click 'Movie Search'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge
    {
        public class __Click__Start_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Start_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/efELgHx8EEmAz58OAnvlKg",
                    DisplayName = "Click 'Start'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge
    {
        public class __Company_Name : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Company_Name(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/GXpxQVtWfk-f2ePYcX8o0Q",
                    DisplayName = "Company Name",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge
    {
        public class __Find : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Find(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/OvShnzWAq0mSWrbrC-zj0Q",
                    DisplayName = "Find",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge
    {
        public class __INPUT : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __INPUT(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/DomUOnK1IEG66pHSv26TrQ",
                    DisplayName = "INPUT",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge
    {
        public class __Movie_Search : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Movie_Search(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/lpqyF6_w6Uuv8OWj5EoaFw",
                    DisplayName = "Movie Search",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge
    {
        public class __Chrome_Rpa_Challenge : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Rpa_Challenge()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/q4FHd0Pg2kyIniPNSt6ANw",
                    DisplayName = "Chrome Rpa Challenge",
                    Screen = this
                };
                Click__Movie_Search_ = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Click__Movie_Search_(this, null);
                Click__Start_ = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Click__Start_(this, null);
                Company_Name = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Company_Name(this, null);
                Find = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Find(this, null);
                INPUT = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__INPUT(this, null);
                Movie_Search = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Movie_Search(this, null);
            }

            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Click__Movie_Search_ Click__Movie_Search_ { get; private set; }
            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Click__Start_ Click__Start_ { get; private set; }
            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Company_Name Company_Name { get; private set; }
            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Find Find { get; private set; }
            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__INPUT INPUT { get; private set; }
            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge.__Movie_Search Movie_Search { get; private set; }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_
    {
        public class __Start : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Start(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/hNdfBeZtn0WDnlOye-DIYg",
                    DisplayName = "Start",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_
    {
        public class __Your_success_rate_is_0__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Your_success_rate_is_0__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/5Dau68yWj0y6Hcn96uNe7Q",
                    DisplayName = "Your success rate is 0%…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_
    {
        public class __Your_success_rate_is_0___1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Your_success_rate_is_0___1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/Vi3sp-HNI06lzE-aHSm7HA",
                    DisplayName = "Your success rate is 0%…(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_
    {
        public class __Your_success_rate_is_10_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Your_success_rate_is_10_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/b9PluHSMN0OCaUfkV_b9Zw",
                    DisplayName = "Your success rate is 10…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Rpa_Challenge
    {
        public class __Chrome_Rpa_Challenge_1_ : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Rpa_Challenge_1_()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/jUEhwCO_wkqYsenmGnVXWQ",
                    DisplayName = "Chrome Rpa Challenge(1)",
                    Screen = this
                };
                Start = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_.__Start(this, null);
                Your_success_rate_is_0__ = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_.__Your_success_rate_is_0__(this, null);
                Your_success_rate_is_0___1_ = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_.__Your_success_rate_is_0___1_(this, null);
                Your_success_rate_is_10_ = new _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_.__Your_success_rate_is_10_(this, null);
            }

            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_.__Start Start { get; private set; }
            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_.__Your_success_rate_is_0__ Your_success_rate_is_0__ { get; private set; }
            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_.__Your_success_rate_is_0___1_ Your_success_rate_is_0___1_ { get; private set; }
            public _Implementation.___Chrome_Rpa_Challenge._Chrome_Rpa_Challenge_1_.__Your_success_rate_is_10_ Your_success_rate_is_10_ { get; private set; }
        }
    }

    namespace ___Chrome_Rpa_Challenge
    {
        public class __Chrome_Rpa_Challenge_2_ : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Rpa_Challenge_2_()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/ftnl3uIy80WHl9mR8oWcFA",
                    DisplayName = "Chrome Rpa Challenge(2)",
                    Screen = this
                };
            }
        }
    }

    namespace _Chrome_Satılık__Kiralık_Emlak_İlanları_sahibinden_com_da._Chrome_Satılık__Kiralık_Emlak_İlanları_sahibi
    {
        public class __Extract_Table_Data : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Extract_Table_Data(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/rTBWZ-f08USZsJLfz6oD9Q",
                    DisplayName = "Extract Table Data",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Satılık__Kiralık_Emlak_İlanları_sahibinden_com_da
    {
        public class __Chrome_Satılık__Kiralık_Emlak_İlanları_sahibi : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Satılık__Kiralık_Emlak_İlanları_sahibi()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "WYLQ-Vi2SUmhLXtd9HrMyg/vWNGkfrQAkWon5RQMYvdNA",
                    DisplayName = "Chrome Satılık, Kiralık Emlak İlanları sahibi",
                    Screen = this
                };
                Extract_Table_Data = new _Implementation._Chrome_Satılık__Kiralık_Emlak_İlanları_sahibinden_com_da._Chrome_Satılık__Kiralık_Emlak_İlanları_sahibi.__Extract_Table_Data(this, null);
            }

            public _Implementation._Chrome_Satılık__Kiralık_Emlak_İlanları_sahibinden_com_da._Chrome_Satılık__Kiralık_Emlak_İlanları_sahibi.__Extract_Table_Data Extract_Table_Data { get; private set; }
        }
    }
}