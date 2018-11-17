using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Shoko.Models.MediaInfo
{
    [DataContract]
    public class Track
    {
        [DataMember(EmitDefaultValue = false, Name = "@type")]
        public string Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ID { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string VideoCount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AudioCount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FileExtension { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Format { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FileSize { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Duration { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string OverallBitRate_Mode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string OverallBitRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FrameRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FrameCount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string File_Created_Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string File_Created_Date_Local { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string File_Modified_Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string File_Modified_Date_Local { get; set; }

        [DataMember(EmitDefaultValue = false,Name="extra")]
        public Dictionary<string,string> Extras { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string StreamOrder { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string MenuID { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Format_Commercial_IfAny { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Format_Profile { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Format_Level { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Format_Tier { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CodecID { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Width { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Height { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Sampled_Width { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Sampled_Height { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string PixelAspectRatio { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string DisplayAspectRatio { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ColorSpace { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ChromaSubsampling { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string BitDepth { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Delay { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Encoded_Library { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Encoded_Library_Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Encoded_Library_Version { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "colour_range")]
        public string Colour_Range { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "colour_description_present")]
        public string Colour_Description_Present { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "colour_primaries")]
        public string Colour_Primaries { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "transfer_characteristics")]
        public string Transfer_Characteristics { get; set; }

        [DataMember(EmitDefaultValue = false,Name= "matrix_coefficients")]
        public string Matrix_Coefficients { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Format_Version { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Format_AdditionalFeatures { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string MuxingMode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string BitRate_Mode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Channels { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ChannelPositions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ChannelLayout { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string SamplesPerFrame { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string SamplingRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string SamplingCount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Compression_Mode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Delay_Source { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string StreamSize { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string HeaderSize { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DataSize { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FooterSize { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string IsStreamable { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Encoded_Date { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Tagged_Date { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Encoded_Application { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BitRate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Rotation { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FrameRate_Mode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FrameRate_Minimum { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FrameRate_Maximum { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Language { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_SBR { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string StreamSize_Proportion { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Default { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AlternateGroup { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Title { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Movie { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ChromaSubsampling_Position { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Forced { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_Mode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_Endianness { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ElementCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string UniqueID { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string TextCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string MenuCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_CABAC { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_RefFrames { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Stored_Height { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FrameRate_Mode_Original { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Encoded_Library_Settings { get; set; }
        [DataMember(EmitDefaultValue = false,Name="@typeorder")]
        public string TypeOrder { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PixelAspectRatio_Original { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DisplayAspectRatio_Original { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ScanType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_Floor { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Encoded_Library_Date { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_BVOP { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_QPel { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_GMC { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_Matrix { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FrameRate_Original { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings_ModeExtension { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Interleaved { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Alignment { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Interleave_VideoFrames { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Interleave_Duration { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Interleave_Preload { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OriginalSourceForm_DistributedBy { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string EncodedBy { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Comment { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Format_Settings { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Channels_Original { get; set; }
        [DataMember(EmitDefaultValue = false,Name= "dialnorm")]
        public string Dialnorm { get; set; }
        [DataMember(EmitDefaultValue = false,Name= "dialnorm_Average")]
        public string Dialnorm_Average { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Subtitle { get; set; }
    }
}