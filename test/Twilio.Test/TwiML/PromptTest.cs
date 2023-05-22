/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.Tests.TwiML
{

    [TestFixture]
    public class PromptTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Prompt();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt />",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Prompt(
                Prompt.ForEnum.PaymentCardNumber,
                new[] {Prompt.ErrorTypeEnum.Timeout},
                new[] {Prompt.CardTypeEnum.Visa},
                new[] {1},
                true
            );
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt for=\"payment-card-number\" errorType=\"timeout\" cardType=\"visa\" attempt=\"1\" requireMatchingInputs=\"true\" />",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Prompt();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt newParam1=\"value\" newParam2=\"1\" />",
                elem.ToString()
            );
        }

        [Test]
        public void TestNestElement()
        {
            var elem = new Prompt();
            var child = new Say();
            elem.Nest(child).Break();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt>" + Environment.NewLine +
                "  <Say>" + Environment.NewLine +
                "    <break />" + Environment.NewLine +
                "  </Say>" + Environment.NewLine +
                "</Prompt>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new Prompt();

            elem.Say("message", Say.VoiceEnum.Man, 1, Say.LanguageEnum.Arb);

            elem.Play(new Uri("https://example.com"), 1, "digits");

            elem.Pause(1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt>" + Environment.NewLine +
                "  <Say voice=\"man\" loop=\"1\" language=\"arb\">message</Say>" + Environment.NewLine +
                "  <Play loop=\"1\" digits=\"digits\">https://example.com</Play>" + Environment.NewLine +
                "  <Pause length=\"1\" />" + Environment.NewLine +
                "</Prompt>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Prompt();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt>Here is the content</Prompt>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Prompt();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Prompt>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Prompt();
            var child = new Say();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt>" + Environment.NewLine +
                "  <Say>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </Say>" + Environment.NewLine +
                "</Prompt>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Prompt();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Prompt>before<Child>content</Child>after</Prompt>",
                elem.ToString()
            );
        }
    }

}