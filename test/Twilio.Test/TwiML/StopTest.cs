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
    public class StopTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Stop();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Stop></Stop>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Stop();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Stop newParam1=\"value\" newParam2=\"1\"></Stop>",
                elem.ToString()
            );
        }

        [Test]
        public void TestNestElement()
        {
            var elem = new Stop();
            var child = new Stream();
            elem.Nest(child).Parameter();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Stop>" + Environment.NewLine +
                "  <Stream>" + Environment.NewLine +
                "    <Parameter></Parameter>" + Environment.NewLine +
                "  </Stream>" + Environment.NewLine +
                "</Stop>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new Stop();

            elem.Stream(
                "name",
                "connector_name",
                "url",
                Stream.TrackEnum.InboundTrack,
                "status_callback",
                Stream.StatusCallbackMethodEnum.Get
            );

            elem.Siprec(
                "name",
                "connector_name",
                Siprec.TrackEnum.InboundTrack,
                "status_callback",
                Siprec.StatusCallbackMethodEnum.Get
            );

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Stop>" + Environment.NewLine +
                "  <Stream name=\"name\" connectorName=\"connector_name\" url=\"url\" track=\"inbound_track\" statusCallback=\"status_callback\" statusCallbackMethod=\"GET\"></Stream>" + Environment.NewLine +
                "  <Siprec name=\"name\" connectorName=\"connector_name\" track=\"inbound_track\" statusCallback=\"status_callback\" statusCallbackMethod=\"GET\"></Siprec>" + Environment.NewLine +
                "</Stop>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Stop();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Stop>Here is the content</Stop>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Stop();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Stop>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Stop>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Stop();
            var child = new Stream();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Stop>" + Environment.NewLine +
                "  <Stream>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </Stream>" + Environment.NewLine +
                "</Stop>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Stop();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Stop>before<Child>content</Child>after</Stop>",
                elem.ToString()
            );
        }
    }

}