using ExifLibrary;

namespace Gradient.Metadata
{
    public static class JpgEditor
    {
        public static List<Tag> AllDateTimes =>            
            new()
            {
                Tag.DateTime,
                Tag.DateTimeDigitized,
                Tag.DateTimeOriginal,
                Tag.ThumbnailDateTime,
                Tag.GPSDateStamp,
            };

        public static void IncrementDateTimeOriginal(string filepath, TimeSpan timeSpan, string newFilepath)
        {
            var dateTime = GetDateTimeOriginal(filepath).Add(timeSpan);
            ReplaceDateTimeOriginal(filepath, newFilepath, dateTime);
        }

        public static void ReplaceDateTimeOriginal(string filepath, string newFilepath, DateTime replacementDateTaken)
        {
            var file = ImageFile.FromFile(filepath);
            ReplaceDateTimeOriginal(replacementDateTaken, file);
            file.Save(newFilepath);
        }

        private static void ReplaceDateTimeOriginal(DateTime replacementDateTaken, ImageFile file)
        {
            ReplaceDateTimes(replacementDateTaken, file, AllDateTimes.ToArray());
        }

        private static void ReplaceDateTimes(DateTime replacementDateTaken, ImageFile file, params Tag[] list)
        {
            foreach (var item in list)
                file.Properties.Set((ExifTag)item, replacementDateTaken);
        }

        public static void ReplaceDateTimeOriginal(string filepath, DateTime replacementDateTaken)
        {
            ReplaceDateTimeOriginal(filepath, filepath, replacementDateTaken);
        }

        public static SortedDictionary<string, string> GetAllMetadata(string filepath)
        {
            var dictionary = new SortedDictionary<string, string>();

            var file = ImageFile.FromFile(filepath);
            foreach (var p in file.Properties)
                dictionary.Add(p.Name, p.Value.ToString());

            return dictionary;
        }

        public static Dictionary<ExifTag, string> GetAllMetadata2(string filepath)
        {
            var dictionary = new Dictionary<ExifTag, string>();

            var file = ImageFile.FromFile(filepath);
            foreach (var p in file.Properties)
                dictionary.Add(p.Tag, p.Value.ToString());

            return dictionary;
        }

        public static DateTime GetDateTimeOriginal(string filepath)
        {
            var file = ImageFile.FromFile(filepath);
            var d = file.Properties.Get(ExifTag.DateTimeOriginal);

            return (DateTime)d.Value;
        }
    }
}