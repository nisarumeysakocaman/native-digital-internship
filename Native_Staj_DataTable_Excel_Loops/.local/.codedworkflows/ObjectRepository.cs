using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Native_Staj_Day3.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Chrome_hava_durumu___Google_da_Ara
        {
            static string _reference = "RXIRTDc2K02W7IsQmT0NzQ/BDtX0ZgELU6ZoqotZXnbuQ";
            public static _Implementation.___Chrome_hava_durumu___Google_da_Ara.__Chrome_hava_durumu___Google_da_Ara Chrome_hava_durumu___Google_da_Ara { get; private set; } = new _Implementation.___Chrome_hava_durumu___Google_da_Ara.__Chrome_hava_durumu___Google_da_Ara();
        }
    }
}

namespace Native_Staj_Day3._Implementation
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

    namespace ___Chrome_hava_durumu___Google_da_Ara
    {
        public class __Chrome_hava_durumu___Google_da_Ara : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_hava_durumu___Google_da_Ara()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "RXIRTDc2K02W7IsQmT0NzQ/sYSX_SJwGUKKTbMG9qUgaA",
                    DisplayName = "Chrome hava durumu - Google'da Ara",
                    Screen = this
                };
            }
        }
    }
}