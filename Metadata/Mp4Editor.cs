using ExifLibrary;
using MediaInfo;

namespace Gradient.Metadata
{
    public static class Mp4Editor
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

        public static void IncrementDateTimeOriginal(string filepath, int days, string newFilepath)
        {
            var dateTime = GetDateTimeOriginal(filepath).AddDays(days);
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
            var mi = new MediaInfo.MediaInfo();

            mi.Open(filepath);
            var x = mi.Inform();

            var videoInfo = new VideoInfo(mi);
            var audioInfo = new AudioInfo(mi);
            mi.Close();

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

    public class VideoInfo
    {
        public string Codec { get; private set; }
        public int Width { get; private set; }
        public int Heigth { get; private set; }
        public double FrameRate { get; private set; }
        public string FrameRateMode { get; private set; }
        public string ScanType { get; private set; }
        public TimeSpan Duration { get; private set; }
        public int Bitrate { get; private set; }
        public string AspectRatioMode { get; private set; }
        public double AspectRatio { get; private set; }

        public VideoInfo(MediaInfo.MediaInfo mi)
        {
            Codec = mi.Get(StreamKind.Video, 0, "Format");
            Width = int.Parse(mi.Get(StreamKind.Video, 0, "Width"));
            Heigth = int.Parse(mi.Get(StreamKind.Video, 0, "Height"));
            Duration = TimeSpan.FromMilliseconds(int.Parse(mi.Get(StreamKind.Video, 0, "Duration")));
            Bitrate = int.Parse(mi.Get(StreamKind.Video, 0, "BitRate"));
            AspectRatioMode = mi.Get(StreamKind.Video, 0, "AspectRatio/String"); //as formatted string
            AspectRatio = double.Parse(mi.Get(StreamKind.Video, 0, "AspectRatio"));
            FrameRate = double.Parse(mi.Get(StreamKind.Video, 0, "FrameRate"));
            FrameRateMode = mi.Get(StreamKind.Video, 0, "FrameRate_Mode");
            ScanType = mi.Get(StreamKind.Video, 0, "ScanType");
        }
    }

    public class AudioInfo
    {
        public string Codec { get; private set; }
        public string CompressionMode { get; private set; }
        public string ChannelPositions { get; private set; }
        public TimeSpan Duration { get; private set; }
        public int Bitrate { get; private set; }
        public string BitrateMode { get; private set; }
        public int SamplingRate { get; private set; }

        public AudioInfo(MediaInfo.MediaInfo mi)
        {
            Codec = mi.Get(StreamKind.Audio, 0, "Format");
            Duration = TimeSpan.FromMilliseconds(int.Parse(mi.Get(StreamKind.Audio, 0, "Duration")));
            Bitrate = int.Parse(mi.Get(StreamKind.Audio, 0, "BitRate"));
            BitrateMode = mi.Get(StreamKind.Audio, 0, "BitRate_Mode");
            CompressionMode = mi.Get(StreamKind.Audio, 0, "Compression_Mode");
            ChannelPositions = mi.Get(StreamKind.Audio, 0, "ChannelPositions");
            SamplingRate = int.Parse(mi.Get(StreamKind.Audio, 0, "SamplingRate"));
        }
    }
}