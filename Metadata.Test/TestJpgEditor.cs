using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace Gradient.Metadata.Test
{
    [TestClass]
    public class TestJpgEditor
    {
        public const string DataDirectory = "TestData";

        [DataTestMethod]
        [DataRow("Capitol.jpg")]
        public void TestReplaceDateTime(string filename)
        {
            var filepath = Path.Combine(DataDirectory, "ReplaceDateTime", filename);
            var newFilepath = Path.Combine($"_{Path.GetFileNameWithoutExtension(filename)}_Replaced_{Guid.NewGuid()}{Path.GetExtension(filepath)}");
            var newDateTime = new DateTime(2010, 11, 12, 13, 14, 15);
            JpgEditor.ReplaceDateTimeOriginal(filepath, newFilepath, newDateTime);
            Assert.AreEqual(JpgEditor.GetDateTimeOriginal(newFilepath), newDateTime);
        }

        [DataTestMethod]
        [DataRow("Capitol2-GetsModifiedInTest.jpg")]
        public void TestReplaceDateTimeOverwrite(string filename)
        {
            var filepath = Path.Combine(DataDirectory, "ReplaceDateTime", filename);
            var newDateTime = new DateTime(2010, 11, 12, 13, 14, 15);
            JpgEditor.ReplaceDateTimeOriginal(filepath, newDateTime);
            Assert.AreEqual(JpgEditor.GetDateTimeOriginal(filepath), newDateTime);
        }

        [DataTestMethod]
        [DataRow("Capitol.jpg", 2001, 08, 31, 12, 38, 31)]
        public void TestGetDateTime(string filename, int year, int month, int day, int hour, int minute, int second)
        {
            var filepath = Path.Combine(DataDirectory, "GetDateTime", filename);
            var dateTime = JpgEditor.GetDateTimeOriginal(filepath);
            Assert.AreEqual(new DateTime(year, month, day, hour, minute, second), dateTime);
        }

        [DataTestMethod]
        [DataRow("Capitol.jpg", 43)]
        public void TestGetAllMetadataAsString(string filename, int expected)
        {
            var filepath = Path.Combine(DataDirectory, "GetDateTime", filename);
            var meta = JpgEditor.GetAllMetadata(filepath);
            Assert.AreEqual(expected, meta.Count());
        }

        [DataTestMethod]
        [DataRow("Capitol.jpg", 43)]
        public void TestGetAllMetadataAsMeta(string filename, int expected)
        {
            var filepath = Path.Combine(DataDirectory, "GetDateTime", filename);
            var meta = JpgEditor.GetAllMetadata2(filepath);
            Assert.AreEqual(expected, meta.Count());
        }

        [DataTestMethod]
        [DataRow("Capitol.jpg", 0, 0, 1)]
        [DataRow("Capitol.jpg", 0, 1, 0)]
        [DataRow("Capitol.jpg", 1, 0, 0)]
        [DataRow("Capitol.jpg", 0, 0, -1)]
        [DataRow("Capitol.jpg", 0, -1, 0)]
        [DataRow("Capitol.jpg", -1, 0, 0)]
        [DataRow("Capitol.jpg", -1, 1, -1)]
        public void TestIncrementDateTime(string filename, int hour, int minute, int second)
        {
            var filepath = Path.Combine(DataDirectory, "ReplaceDateTime", filename);
            var dateTime = JpgEditor.GetDateTimeOriginal(filepath);

            var newFilepath = Path.Combine($"_{Path.GetFileNameWithoutExtension(filename)}_Incremented_{Guid.NewGuid()}{Path.GetExtension(filepath)}");
            var timespan = new TimeSpan(hour, minute, second);
            var newDateTime = dateTime.Add(timespan);

            Assert.IsFalse(dateTime == newDateTime);

            JpgEditor.IncrementDateTimeOriginal(filepath, timespan, newFilepath);
            Assert.AreEqual(JpgEditor.GetDateTimeOriginal(newFilepath), newDateTime);
        }

        [DataTestMethod]
        [DataRow("Capitol.jpg", 0)]
        [DataRow("Capitol.jpg", 1)]
        [DataRow("Capitol.jpg", 2)]
        [DataRow("Capitol.jpg", -1)]
        [DataRow("Capitol.jpg", -2)]
        public void TestIncrementDateTime2(string filename, int days)
        {
            var filepath = Path.Combine(DataDirectory, "ReplaceDateTime", filename);
            var dateTime = JpgEditor.GetDateTimeOriginal(filepath);

            var newFilepath = Path.Combine($"_{Path.GetFileNameWithoutExtension(filename)}_Incremented_{Guid.NewGuid()}{Path.GetExtension(filepath)}");
            var newDateTime = dateTime.AddDays(days);

            if (days != 0)
                Assert.IsFalse(dateTime == newDateTime);

            JpgEditor.IncrementDateTimeOriginal(filepath, days, newFilepath);
            Assert.AreEqual(JpgEditor.GetDateTimeOriginal(newFilepath), newDateTime);
        }
    }
}