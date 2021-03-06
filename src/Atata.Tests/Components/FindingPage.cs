﻿using _ = Atata.Tests.FindingPage;

namespace Atata.Tests
{
    [Url("Finding.html")]
    [VerifyTitle]
    [VerifyH1]
    public class FindingPage : Page<_>
    {
        [FindByIndex(2)]
        public RadioButton<_> OptionCByIndex { get; private set; }

        [FindByName("radio-options", Index = 2)]
        public RadioButton<_> OptionCByName { get; private set; }

        [FindByCss("[name='radio-options']", Index = 2)]
        public RadioButton<_> OptionCByCss { get; private set; }

        [FindByXPath("non-existent", "*[@name='radio-options']", Index = 2)]
        public RadioButton<_> OptionCByXPath { get; private set; }

        [FindByXPath("[@name='radio-options']", Index = 2)]
        public RadioButton<_> OptionCByXPathCondition { get; private set; }

        [FindByXPath("@name='radio-options'", Index = 2)]
        public RadioButton<_> OptionCByXPathAttribute { get; private set; }

        [FindByAttribute("name", "radio-options", Index = 2)]
        public RadioButton<_> OptionCByAttribute { get; private set; }

        [FindByClass("radio-options", Index = 2)]
        public RadioButton<_> OptionCByClass { get; private set; }

        [FindLast]
        public RadioButton<_> OptionDAsLast { get; private set; }

        [FindById]
        public TextInput<_> VisibleInput { get; private set; }

        [FindById(Visibility = Visibility.Hidden)]
        public TextInput<_> DisplayNoneInput { get; private set; }

        [FindById("display-none-input")]
        public TextInput<_> FailDisplayNoneInput { get; private set; }

        [FindById(Visibility = Visibility.Hidden)]
        public TextInput<_> HiddenInput { get; private set; }

        [FindById(Visibility = Visibility.Hidden)]
        public TextInput<_> CollapseInput { get; private set; }

        [FindById]
        public HiddenInput<_> TypeHiddenInput { get; private set; }

        [ControlDefinition("input[@type='hidden']", Visibility = Visibility.Hidden)]
        [FindById("type-hidden-input")]
        public Input<string, _> TypeHiddenInputWithDeclaredDefinition { get; private set; }

        [FindByCss("[value='OptionC']", OuterXPath = ".//*[@class='x-radio-container']/")]
        public RadioButton<_> OptionCByCssWithOuterXPath { get; private set; }

        [FindByCss("[value='OptionC']", OuterXPath = ".//*[@class='unknown']/")]
        public RadioButton<_> MissingOptionByCssWithOuterXPath { get; private set; }

        [FindByCss("[name='unknown']")]
        public RadioButton<_> MissingOptionByCss { get; private set; }

        [FindByLabel("unknown")]
        public RadioButton<_> MissingOptionByLabel { get; private set; }

        [FindByXPath("*[@name='unknown']")]
        public RadioButton<_> MissingOptionByXPath { get; private set; }

        [FindById("unknown")]
        public RadioButton<_> MissingOptionById { get; private set; }

        [FindByColumnHeader("unknown")]
        public RadioButton<_> MissingOptionByColumnHeader { get; private set; }
    }
}
