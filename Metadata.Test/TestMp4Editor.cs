using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace Gradient.Metadata.Test
{
    [TestClass]
    public class TestMp4Editor
    {
        public const string DataDirectory = "TestDataMp4";

        [DataTestMethod]
        [DataRow("baby.mp4", 43)]
        public void TestGetAllMetadataAsMeta(string filename, int expected)
        {
            var filepath = Path.Combine(DataDirectory, "GetDateTime", filename);
            var meta = Mp4Editor.GetAllMetadata2(filepath);
            Assert.AreEqual(expected, meta.Count());
        }
    }
}