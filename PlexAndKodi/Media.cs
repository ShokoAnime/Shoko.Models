using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Shoko.Plugin.Abstractions.Extensions;
using Shoko.Plugin.Abstractions.Models;

// ReSharper disable StringLiteralTypo

namespace Shoko.Models.PlexAndKodi
{
    [XmlType("Media")]
    [DataContract]
    [Serializable]
    public class Media : ICloneable
    {
        [DataMember(EmitDefaultValue = false, Order = 1)]
        [XmlElement("Part")]
        public List<Part> Parts { get; set; }

        [DataMember(EmitDefaultValue = true, Order = 2)]
        [XmlAttribute("duration")]
        public long Duration { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        [XmlAttribute("videoFrameRate")]
        public string VideoFrameRate { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 4)]
        [XmlAttribute("container")]
        public string Container { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 5)]
        [XmlAttribute("videoCodec")]
        public string VideoCodec { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 6)]
        [XmlAttribute("audioCodec")]
        public string AudioCodec { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 7)]
        [XmlAttribute("audioChannels")]
        public byte AudioChannels { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 8)]
        [XmlAttribute("aspectRatio")]
        public float AspectRatio { get; set; }

        [DataMember(EmitDefaultValue = true, Order = 9)]
        [XmlAttribute("height")]
        public int Height { get; set; }

        [DataMember(EmitDefaultValue = true, Order = 10)]
        [XmlAttribute("width")]
        public int Width { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 11)]
        [XmlAttribute("bitrate")]
        public int Bitrate { get; set; }

        [DataMember(EmitDefaultValue = true, Order = 12)]
        [XmlAttribute("id")]
        public int Id { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 13)]
        [XmlAttribute("videoResolution")]
        public string VideoResolution { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 14)]
        [XmlAttribute("optimizedForStreaming")]
        public byte OptimizedForStreaming { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 15)]
        [XmlAttribute("chaptered")]
        public bool Chaptered { get; set; }

        public object Clone()
        {
            Media newMedia = new Media
            {
                Parts = Parts?.Select(a => (Part)a.Clone()).ToList(),
                Duration = Duration,
                VideoFrameRate = VideoFrameRate,
                Container = Container,
                VideoCodec = VideoCodec,
                AudioCodec = AudioCodec,
                AudioChannels = AudioChannels,
                AspectRatio = AspectRatio,
                Height = Height,
                Width = Width,
                Bitrate = Bitrate,
                Id = Id,
                VideoResolution = VideoResolution,
                OptimizedForStreaming = OptimizedForStreaming,
                Chaptered = Chaptered
            };
            return newMedia;
        }

        public Media()
        {

        }

        /// <summary>
        /// Generate a Legacy Media model from the VideoLocalID and MediaContainer
        /// </summary>
        /// <param name="id"></param>
        /// <param name="m"></param>
        public Media(int id, IMediaInfo m)
        {
            Id = id;
            Chaptered = m.Chapters.Any();
            Duration = (long)m.Duration.TotalMilliseconds;
            Bitrate = m.BitRate;
            Container = m.FileExtension;
            OptimizedForStreaming = (byte)(m.IsStreamable ? 1 : 0);
            var videoStream = m.Video.FirstOrDefault();
            if (videoStream != null)
            {
                Height = videoStream.Height;
                Width = videoStream.Width;
                AspectRatio = (float)videoStream.Width / videoStream.Height;
                VideoResolution = videoStream.Resolution;
                VideoFrameRate = TranslateFrameRate(m);
                VideoCodec = videoStream.Codec.Raw;
            }

            var audioStream = m.Audio.FirstOrDefault();
            if (audioStream != null)
            {
                AudioChannels = (byte)audioStream.Channels;
                AudioCodec = audioStream.Codec.Raw;
            }

            Parts = new List<Part>
            {
                new Part
                {
                    Streams = new List<Stream>()
                }
            };
            Parts[0].Streams.Add(Media.TranslateVideoStream(m));
            Parts[0].Streams.AddRange(Media.TranslateAudioStreams(m));
            Parts[0].Streams.AddRange(Media.TranslateTextStreams(m));
        }

        public static PlexAndKodi.Stream TranslateVideoStream(IMediaInfo mediaInfo)
        {
            var video = mediaInfo?.Video.FirstOrDefault();
            if (video == null)
                return null;

            var codec = video.Codec;
            var format = video.Format;
            var stream = new PlexAndKodi.Stream
            {
                Id = video.ID,
                Codec = codec.Simplified,
                CodecID = codec.Raw,
                StreamType = 1,
                Width = video.Width,
                Height = video.Height,
                Duration = (long)mediaInfo.Duration.TotalMilliseconds,
                Title = video.Title,
                LanguageCode = video.LanguageCode,
                Language = video.Language?.GetDescription(),
                BitDepth = (byte)video.BitDepth,
                Index = (byte)video.ID,
                QPel = (byte)(format.QPel ? 1 : 0),
                GMC = format.GMC,
                Default = (byte)(video.IsDefault ? 1 : 0),
                Forced = (byte)(video.IsForced ? 1 : 0),
                PA = (float)video.PixelAspectRatio,
                Bitrate = (int)Math.Round(video.BitRate / 1000F),
                ScanType = video.ScanType?.ToLower(),
                RefFrames = (byte)(format.ReferenceFrames ?? 0),
                HeaderStripping =
                    (byte)(video.Muxing.Raw?.IndexOf("strip", StringComparison.InvariantCultureIgnoreCase) != -1
                        ? 1
                        : 0),
                Cabac = (byte)(format.CABAC ? 1 : 0),
                FrameRateMode = video.FrameRateMode?.ToLower(CultureInfo.InvariantCulture),
                FrameRate = (float)video.FrameRate,
                ColorSpace = video.ColorSpace?.ToLower(CultureInfo.InvariantCulture),
                ChromaSubsampling = video.ChromaSubsampling?.ToLower(CultureInfo.InvariantCulture),
                BVOP = (byte)(format.BVOP && codec.Simplified != "mpeg1" ? 1 : 0),
            };

            if (stream.PA != 1.0 && stream.Width != 0)
            {
                if (stream.Width != 0)
                {
                    float width = stream.Width;
                    width *= stream.PA;
                    stream.PixelAspectRatio = $"{(int)Math.Round(width)}:{stream.Width}";
                }
            }

            string formatProfile = format.Profile?.ToLower(CultureInfo.InvariantCulture);
            if (!string.IsNullOrEmpty(formatProfile))
            {
                var atSymbol = formatProfile.IndexOf("@", StringComparison.Ordinal);
                if (atSymbol != -1)
                {
                    stream.Profile = TranslateProfile(codec.Simplified, formatProfile[0..atSymbol]);
                    if (int.TryParse(TranslateLevel(formatProfile[(atSymbol + 1)..]), out int level))
                        stream.Level = level;
                }
                else
                    stream.Profile = TranslateProfile(codec.Simplified, formatProfile);
            }

            stream.HasScalingMatrix = (byte)(codec.Simplified == "h264" && stream.Level == 31 && !format.CABAC ? 1 : 0);

            return stream;
        }

        public static IEnumerable<PlexAndKodi.Stream> TranslateAudioStreams(IMediaInfo mediaInfo)
        {
            if (mediaInfo == null)
                return new List<PlexAndKodi.Stream>();

            return mediaInfo.Audio
                .Select(audioStream =>
                {
                    var codec = audioStream.Codec;
                    var format = audioStream.Format;
                    var stream = new PlexAndKodi.Stream()
                    {
                        Id = audioStream.ID,
                        CodecID = codec.Raw,
                        Codec = codec.Simplified,
                        Title = audioStream.Title,
                        StreamType = 2,
                        LanguageCode = audioStream.LanguageCode,
                        Language = audioStream.Language?.GetDescription(),
                        Duration = (int)mediaInfo.Duration.TotalMilliseconds,
                        Index = (byte)audioStream.ID,
                        Bitrate = (int)Math.Round(audioStream.BitRate / 1000F),
                        BitDepth = (byte)audioStream.BitDepth,
                        SamplingRate = audioStream.SamplingRate,
                        Channels = (byte)audioStream.Channels,
                        BitrateMode = audioStream.BitRateMode?.ToLower(CultureInfo.InvariantCulture),
                        DialogNorm = audioStream.DialogNorm?.ToString(),
                        Default = (byte)(audioStream.IsDefault ? 1 : 0),
                        Forced = (byte)(audioStream.IsForced ? 1 : 0)
                    };

                    string formatProfile = format.Profile?.ToLower(CultureInfo.InvariantCulture);
                    if (!string.IsNullOrEmpty(formatProfile))
                    {
                        if (formatProfile != "layer 3" &&
                            formatProfile != "dolby digital" &&
                            formatProfile != "pro" &&
                            formatProfile != "layer 2")
                            stream.Profile = formatProfile;
                        if (formatProfile.StartsWith("ma"))
                            stream.Profile = "ma";
                    }

                    if (!string.IsNullOrEmpty(format.Settings))
                    {
                        switch (format.Settings)
                        {
                            case "Little / Signed" when codec.Simplified == "pcm" && audioStream.BitDepth == 16:
                                stream.Profile = "pcm_s16le";
                                break;
                            case "Big / Signed" when codec.Simplified == "pcm" && audioStream.BitDepth == 16:
                                stream.Profile = "pcm_s16be";
                                break;
                            case "Little / Unsigned" when codec.Simplified == "pcm" && audioStream.BitDepth == 8:
                                stream.Profile = "pcm_u8";
                                break;
                        }
                    }

                    return stream;
                })
                .ToList();
        }

        public static IEnumerable<PlexAndKodi.Stream> TranslateTextStreams(IMediaInfo mediaInfo)
        {
            if (mediaInfo == null)
                return new List<PlexAndKodi.Stream>();

            return mediaInfo.Subtitles
                .Select(textStream =>
                {
                    var codec = textStream.Codec;
                    return new PlexAndKodi.Stream
                    {
                        Id = textStream.ID,
                        CodecID = codec.Raw,
                        StreamType = 3,
                        Title = textStream.SubTitle ?? textStream.Title,
                        LanguageCode = textStream.LanguageCode,
                        Language = textStream.Language?.GetDescription(),
                        Index = (byte)textStream.ID,
                        Format = codec.Simplified,
                        Codec = codec.Simplified,
                        Default = (byte)(textStream.IsDefault ? 1 : 0),
                        Forced = (byte)(textStream.IsForced ? 1 : 0),
                        File = textStream.IsExternal ? textStream.ExternalFilename : null
                    };
                })
                .ToList();
        }

        private static string TranslateFrameRate(IMediaInfo m)
        {
            var videoStream = m?.Video.FirstOrDefault();
            if ((videoStream?.FrameRate ?? 0) == 0) return null;
            float fr = System.Convert.ToSingle(videoStream.FrameRate, CultureInfo.InvariantCulture);
            string frs = ((int)Math.Round(fr)).ToString(CultureInfo.InvariantCulture);
            if (!string.IsNullOrEmpty(videoStream.ScanType))
            {
                if (videoStream.ScanType.ToLower().Contains("int"))
                    frs += "i";
                else
                    frs += "p";
            }
            else
                frs += "p";

            switch (frs)
            {
                case "25p":
                case "25i":
                    frs = "PAL";
                    break;
                case "30p":
                case "30i":
                    frs = "NTSC";
                    break;
            }

            return frs;
        }
        private static string TranslateProfile(string codec, string profile)
        {
            profile = profile.ToLowerInvariant();

            if (profile.Contains("advanced simple"))
                return "asp";
            if (codec == "mpeg4" && profile.Equals("simple"))
                return "sp";
            if (profile.StartsWith("m"))
                return "main";
            if (profile.StartsWith("s"))
                return "simple";
            if (profile.StartsWith("a"))
                return "advanced";
            return profile;
        }

        private static string TranslateLevel(string level)
        {
            level = level.Replace(".", string.Empty).ToLowerInvariant();
            if (level.StartsWith("l"))
            {
                int.TryParse(level.Substring(1), out int lll);
                if (lll != 0)
                    level = lll.ToString(CultureInfo.InvariantCulture);
                else if (level.StartsWith("lm"))
                    level = "medium";
                else if (level.StartsWith("lh"))
                    level = "high";
                else
                    level = "low";
            }
            else if (level.StartsWith("m"))
                level = "medium";
            else if (level.StartsWith("h"))
                level = "high";

            return level;
        }
    }
}
