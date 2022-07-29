using ExifLibrary;

namespace Gradient.Metadata
{
    /// <summary>
    /// Simple mapper so that we can give the properties comments!
    /// </summary>
    public enum Tag
    {
        /// <summary>
        ///
        /// </summary>
        ApertureValue = ExifTag.ApertureValue,

        /// <summary>
        ///
        /// </summary>
        Artist = ExifTag.Artist,

        /// <summary>
        ///
        /// </summary>
        BitsPerSample = ExifTag.BitsPerSample,

        /// <summary>
        ///
        /// </summary>
        BodySerialNumber = ExifTag.BodySerialNumber,

        /// <summary>
        ///
        /// </summary>
        BrightnessValue = ExifTag.BrightnessValue,

        /// <summary>
        ///
        /// </summary>
        CFAPattern = ExifTag.CFAPattern,

        /// <summary>
        ///
        /// </summary>
        CameraOwnerName = ExifTag.CameraOwnerName,

        /// <summary>
        ///
        /// </summary>
        CellLength = ExifTag.CellLength,

        /// <summary>
        ///
        /// </summary>
        CellWidth = ExifTag.CellWidth,

        /// <summary>
        ///
        /// </summary>
        ColorMap = ExifTag.ColorMap,

        /// <summary>
        ///
        /// </summary>
        ColorSpace = ExifTag.ColorSpace,

        /// <summary>
        ///
        /// </summary>
        ComponentsConfiguration = ExifTag.ComponentsConfiguration,

        /// <summary>
        ///
        /// </summary>
        CompressedBitsPerPixel = ExifTag.CompressedBitsPerPixel,

        /// <summary>
        ///
        /// </summary>
        Compression = ExifTag.Compression,

        /// <summary>
        ///
        /// </summary>
        Contrast = ExifTag.Contrast,

        /// <summary>
        ///
        /// </summary>
        Copyright = ExifTag.Copyright,

        /// <summary>
        ///
        /// </summary>
        CustomRendered = ExifTag.CustomRendered,

        /// <summary>
        /// Modify date
        /// </summary>
        DateTime = ExifTag.DateTime,

        /// <summary>
        ///	Create date
        /// </summary>
        DateTimeDigitized = ExifTag.DateTimeDigitized,

        /// <summary>
        /// Date taken
        /// </summary>
        DateTimeOriginal = ExifTag.DateTimeOriginal,

        /// <summary>
        ///
        /// </summary>
        DeviceSettingDescription = ExifTag.DeviceSettingDescription,

        /// <summary>
        ///
        /// </summary>
        DigitalZoomRatio = ExifTag.DigitalZoomRatio,

        /// <summary>
        ///
        /// </summary>
        DocumentName = ExifTag.DocumentName,

        /// <summary>
        ///
        /// </summary>
        DotRange = ExifTag.DotRange,

        /// <summary>
        ///
        /// </summary>
        EXIFIFDPointer = ExifTag.EXIFIFDPointer,

        /// <summary>
        ///
        /// </summary>
        ExifIFDPadding = ExifTag.ExifIFDPadding,

        /// <summary>
        ///
        /// </summary>
        ExifVersion = ExifTag.ExifVersion,

        /// <summary>
        ///
        /// </summary>
        ExposureBiasValue = ExifTag.ExposureBiasValue,

        /// <summary>
        ///
        /// </summary>
        ExposureIndex = ExifTag.ExposureIndex,

        /// <summary>
        ///
        /// </summary>
        ExposureMode = ExifTag.ExposureMode,

        /// <summary>
        ///
        /// </summary>
        ExposureProgram = ExifTag.ExposureProgram,

        /// <summary>
        ///
        /// </summary>
        ExposureTime = ExifTag.ExposureTime,

        /// <summary>
        ///
        /// </summary>
        ExtraSamples = ExifTag.ExtraSamples,

        /// <summary>
        ///
        /// </summary>
        FNumber = ExifTag.FNumber,

        /// <summary>
        ///
        /// </summary>
        FileSource = ExifTag.FileSource,

        /// <summary>
        ///
        /// </summary>
        FillOrder = ExifTag.FillOrder,

        /// <summary>
        ///
        /// </summary>
        Flash = ExifTag.Flash,

        /// <summary>
        ///
        /// </summary>
        FlashEnergy = ExifTag.FlashEnergy,

        /// <summary>
        ///
        /// </summary>
        FlashpixVersion = ExifTag.FlashpixVersion,

        /// <summary>
        ///
        /// </summary>
        FocalLength = ExifTag.FocalLength,

        /// <summary>
        ///
        /// </summary>
        FocalLengthIn35mmFilm = ExifTag.FocalLengthIn35mmFilm,

        /// <summary>
        ///
        /// </summary>
        FocalPlaneResolutionUnit = ExifTag.FocalPlaneResolutionUnit,

        /// <summary>
        ///
        /// </summary>
        FocalPlaneXResolution = ExifTag.FocalPlaneXResolution,

        /// <summary>
        ///
        /// </summary>
        FocalPlaneYResolution = ExifTag.FocalPlaneYResolution,

        /// <summary>
        ///
        /// </summary>
        FreeByteCounts = ExifTag.FreeByteCounts,

        /// <summary>
        ///
        /// </summary>
        FreeOffsets = ExifTag.FreeOffsets,

        /// <summary>
        /// 
        /// </summary>
        GIFComment = 1000000,

        /// <summary>
        /// 
        /// </summary>
        GPSAltitude = ExifTag.GPSAltitude,
        /// <summary>
        ///
        /// </summary>
        GPSAltitudeRef = ExifTag.GPSAltitudeRef,

        /// <summary>
        ///
        /// </summary>
        GPSAreaInformation = ExifTag.GPSAreaInformation,

        /// <summary>
        ///
        /// </summary>
        GPSDOP = ExifTag.GPSDOP,

        /// <summary>
        ///
        /// </summary>
        GPSDateStamp = ExifTag.GPSDateStamp,

        /// <summary>
        ///
        /// </summary>
        GPSDestBearing = ExifTag.GPSDestBearing,

        /// <summary>
        ///
        /// </summary>
        GPSDestBearingRef = ExifTag.GPSDestBearingRef,

        /// <summary>
        ///
        /// </summary>
        GPSDestDistance = ExifTag.GPSDestDistance,

        /// <summary>
        ///
        /// </summary>
        GPSDestDistanceRef = ExifTag.GPSDestDistanceRef,

        /// <summary>
        ///
        /// </summary>
        GPSDestLatitude = ExifTag.GPSDestLatitude,

        /// <summary>
        ///
        /// </summary>
        GPSDestLatitudeRef = ExifTag.GPSDestLatitudeRef,

        /// <summary>
        ///
        /// </summary>
        GPSDestLongitude = ExifTag.GPSDestLongitude,

        /// <summary>
        ///
        /// </summary>
        GPSDestLongitudeRef = ExifTag.GPSDestLongitudeRef,

        /// <summary>
        ///
        /// </summary>
        GPSDifferential = ExifTag.GPSDifferential,

        /// <summary>
        ///
        /// </summary>
        GPSIFDPointer = ExifTag.GPSIFDPointer,

        /// <summary>
        ///
        /// </summary>
        GPSImgDirection = ExifTag.GPSImgDirection,

        /// <summary>
        ///
        /// </summary>
        GPSImgDirectionRef = ExifTag.GPSImgDirectionRef,

        /// <summary>
        ///
        /// </summary>
        GPSLatitude = ExifTag.GPSLatitude,

        /// <summary>
        ///
        /// </summary>
        GPSLatitudeRef = ExifTag.GPSLatitudeRef,

        /// <summary>
        ///
        /// </summary>
        GPSLongitude = ExifTag.GPSLongitude,

        /// <summary>
        ///
        /// </summary>
        GPSLongitudeRef = ExifTag.GPSLongitudeRef,

        /// <summary>
        ///
        /// </summary>
        GPSMapDatum = ExifTag.GPSMapDatum,

        /// <summary>
        ///
        /// </summary>
        GPSMeasureMode = ExifTag.GPSMeasureMode,

        /// <summary>
        ///
        /// </summary>
        GPSProcessingMethod = ExifTag.GPSProcessingMethod,

        /// <summary>
        ///
        /// </summary>
        GPSSatellites = ExifTag.GPSSatellites,

        /// <summary>
        ///
        /// </summary>
        GPSSpeed = ExifTag.GPSSpeed,

        /// <summary>
        ///
        /// </summary>
        GPSSpeedRef = ExifTag.GPSSpeedRef,

        /// <summary>
        ///
        /// </summary>
        GPSStatus = ExifTag.GPSStatus,

        /// <summary>
        ///
        /// </summary>
        GPSTimeStamp = ExifTag.GPSTimeStamp,

        /// <summary>
        ///
        /// </summary>
        GPSTrack = ExifTag.GPSTrack,

        /// <summary>
        ///
        /// </summary>
        GPSTrackRef = ExifTag.GPSTrackRef,

        /// <summary>
        ///
        /// </summary>
        GPSVersionID = ExifTag.GPSVersionID,

        /// <summary>
        ///
        /// </summary>
        GainControl = ExifTag.GainControl,

        /// <summary>
        ///
        /// </summary>
        GrayResponseCurve = ExifTag.GrayResponseCurve,

        /// <summary>
        ///
        /// </summary>
        GrayResponseUnit = ExifTag.GrayResponseUnit,

        /// <summary>
        ///
        /// </summary>
        HalftoneHints = ExifTag.HalftoneHints,

        /// <summary>
        ///
        /// </summary>
        HostComputer = ExifTag.HostComputer,

        /// <summary>
        ///
        /// </summary>
        ISOSpeedRatings = ExifTag.ISOSpeedRatings,

        /// <summary>
        ///
        /// </summary>
        ImageDescription = ExifTag.ImageDescription,

        /// <summary>
        ///
        /// </summary>
        ImageLength = ExifTag.ImageLength,

        /// <summary>
        ///
        /// </summary>
        ImageUniqueID = ExifTag.ImageUniqueID,

        /// <summary>
        ///
        /// </summary>
        ImageWidth = ExifTag.ImageWidth,

        /// <summary>
        ///
        /// </summary>
        InkNames = ExifTag.InkNames,

        /// <summary>
        ///
        /// </summary>
        InkSet = ExifTag.InkSet,

        /// <summary>
        ///
        /// </summary>
        InteroperabilityIFDPointer = ExifTag.InteroperabilityIFDPointer,

        /// <summary>
        ///
        /// </summary>
        InteroperabilityIndex = ExifTag.InteroperabilityIndex,

        /// <summary>
        ///
        /// </summary>
        InteroperabilityVersion = ExifTag.InteroperabilityVersion,

        /// <summary>
        ///
        /// </summary>
        JFIFThumbnail = ExifTag.JFIFThumbnail,

        /// <summary>
        ///
        /// </summary>
        JFIFUnits = ExifTag.JFIFUnits,

        /// <summary>
        ///
        /// </summary>
        JFIFVersion = ExifTag.JFIFVersion,

        /// <summary>
        ///
        /// </summary>
        JFIFXThumbnail = ExifTag.JFIFXThumbnail,

        /// <summary>
        ///
        /// </summary>
        JFIFYThumbnail = ExifTag.JFIFYThumbnail,

        /// <summary>
        ///
        /// </summary>
        JFXXExtensionCode = ExifTag.JFXXExtensionCode,

        /// <summary>
        ///
        /// </summary>
        JFXXPalette = ExifTag.JFXXPalette,

        /// <summary>
        ///
        /// </summary>
        JFXXThumbnail = ExifTag.JFXXThumbnail,

        /// <summary>
        ///
        /// </summary>
        JFXXXThumbnail = ExifTag.JFXXXThumbnail,

        /// <summary>
        ///
        /// </summary>
        JFXXYThumbnail = ExifTag.JFXXYThumbnail,

        /// <summary>
        ///
        /// </summary>
        JPEGACTables = ExifTag.JPEGACTables,

        /// <summary>
        ///
        /// </summary>
        JPEGDCTables = ExifTag.JPEGDCTables,

        /// <summary>
        ///
        /// </summary>
        JPEGInterchangeFormat = ExifTag.JPEGInterchangeFormat,

        /// <summary>
        ///
        /// </summary>
        JPEGInterchangeFormatLength = ExifTag.JPEGInterchangeFormatLength,

        /// <summary>
        ///
        /// </summary>
        JPEGLosslessPredictors = ExifTag.JPEGLosslessPredictors,

        /// <summary>
        ///
        /// </summary>
        JPEGPointTransforms = ExifTag.JPEGPointTransforms,

        /// <summary>
        ///
        /// </summary>
        JPEGProc = ExifTag.JPEGProc,

        /// <summary>
        ///
        /// </summary>
        JPEGQTables = ExifTag.JPEGQTables,

        /// <summary>
        ///
        /// </summary>
        JPEGRestartInterval = ExifTag.JPEGRestartInterval,

        /// <summary>
        ///
        /// </summary>
        LensMake = ExifTag.LensMake,

        /// <summary>
        ///
        /// </summary>
        LensModel = ExifTag.LensModel,

        /// <summary>
        ///
        /// </summary>
        LensSerialNumber = ExifTag.LensSerialNumber,

        /// <summary>
        ///
        /// </summary>
        LensSpecification = ExifTag.LensSpecification,

        /// <summary>
        ///
        /// </summary>
        LightSource = ExifTag.LightSource,

        /// <summary>
        ///
        /// </summary>
        Make = ExifTag.Make,

        /// <summary>
        ///
        /// </summary>
        MakerNote = ExifTag.MakerNote,

        /// <summary>
        ///
        /// </summary>
        MaxApertureValue = ExifTag.MaxApertureValue,

        /// <summary>
        ///
        /// </summary>
        MaxSampleValue = ExifTag.MaxSampleValue,

        /// <summary>
        ///
        /// </summary>
        MeteringMode = ExifTag.MeteringMode,

        /// <summary>
        ///
        /// </summary>
        MinSampleValue = ExifTag.MinSampleValue,

        /// <summary>
        ///
        /// </summary>
        Model = ExifTag.Model,

        /// <summary>
        ///
        /// </summary>
        NewSubfileType = ExifTag.NewSubfileType,

        /// <summary>
        ///
        /// </summary>
        NumberOfInks = ExifTag.NumberOfInks,

        /// <summary>
        ///
        /// </summary>
        OECF = ExifTag.OECF,

        /// <summary>
        ///
        /// </summary>
        OffsetSchema = ExifTag.OffsetSchema,

        /// <summary>
        ///
        /// </summary>
        Orientation = ExifTag.Orientation,

        /// <summary>
        ///
        /// </summary>
        PNGAuthor = ExifTag.PNGAuthor,

        /// <summary>
        ///
        /// </summary>
        PNGComment = ExifTag.PNGComment,

        /// <summary>
        ///
        /// </summary>
        PNGCopyright = ExifTag.PNGCopyright,

        /// <summary>
        ///
        /// </summary>
        PNGCreationTime = ExifTag.PNGCreationTime,

        /// <summary>
        ///
        /// </summary>
        PNGDescription = ExifTag.PNGDescription,

        /// <summary>
        ///
        /// </summary>
        PNGDisclaimer = ExifTag.PNGDisclaimer,

        /// <summary>
        ///
        /// </summary>
        PNGSoftware = ExifTag.PNGSoftware,

        /// <summary>
        ///
        /// </summary>
        PNGSource = ExifTag.PNGSource,

        /// <summary>
        ///
        /// </summary>
        PNGText = ExifTag.PNGText,

        /// <summary>
        ///
        /// </summary>
        PNGTimeStamp = ExifTag.PNGTimeStamp,

        /// <summary>
        ///
        /// </summary>
        PNGTitle = ExifTag.PNGTitle,

        /// <summary>
        ///
        /// </summary>
        PNGWarning = ExifTag.PNGWarning,

        /// <summary>
        ///
        /// </summary>
        PageName = ExifTag.PageName,

        /// <summary>
        ///
        /// </summary>
        PageNumber = ExifTag.PageNumber,

        /// <summary>
        ///
        /// </summary>
        PhotometricInterpretation = ExifTag.PhotometricInterpretation,

        /// <summary>
        ///
        /// </summary>
        PixelXDimension = ExifTag.PixelXDimension,

        /// <summary>
        ///
        /// </summary>
        PixelYDimension = ExifTag.PixelYDimension,

        /// <summary>
        ///
        /// </summary>
        PlanarConfiguration = ExifTag.PlanarConfiguration,

        /// <summary>
        ///
        /// </summary>
        Predictor = ExifTag.Predictor,

        /// <summary>
        ///
        /// </summary>
        PrimaryChromaticities = ExifTag.PrimaryChromaticities,

        /// <summary>
        ///
        /// </summary>
        Rating = ExifTag.Rating,

        /// <summary>
        ///
        /// </summary>
        RatingPercent = ExifTag.RatingPercent,

        /// <summary>
        ///
        /// </summary>
        ReferenceBlackWhite = ExifTag.ReferenceBlackWhite,

        /// <summary>
        ///
        /// </summary>
        RelatedImageHeight = ExifTag.RelatedImageHeight,

        /// <summary>
        ///
        /// </summary>
        RelatedImageWidth = ExifTag.RelatedImageWidth,

        /// <summary>
        ///
        /// </summary>
        RelatedSoundFile = ExifTag.RelatedSoundFile,

        /// <summary>
        ///
        /// </summary>
        ResolutionUnit = ExifTag.ResolutionUnit,

        /// <summary>
        ///
        /// </summary>
        RowsPerStrip = ExifTag.RowsPerStrip,

        /// <summary>
        ///
        /// </summary>
        SMaxSampleValue = ExifTag.SMaxSampleValue,

        /// <summary>
        ///
        /// </summary>
        SMinSampleValue = ExifTag.SMinSampleValue,

        /// <summary>
        ///
        /// </summary>
        SampleFormat = ExifTag.SampleFormat,

        /// <summary>
        ///
        /// </summary>
        SamplesPerPixel = ExifTag.SamplesPerPixel,

        /// <summary>
        ///
        /// </summary>
        Saturation = ExifTag.Saturation,

        /// <summary>
        ///
        /// </summary>
        SceneCaptureType = ExifTag.SceneCaptureType,

        /// <summary>
        ///
        /// </summary>
        SceneType = ExifTag.SceneType,

        /// <summary>
        ///
        /// </summary>
        SensingMethod = ExifTag.SensingMethod,

        /// <summary>
        ///
        /// </summary>
        Sharpness = ExifTag.Sharpness,

        /// <summary>
        ///
        /// </summary>
        ShutterSpeedValue = ExifTag.ShutterSpeedValue,

        /// <summary>
        ///
        /// </summary>
        Software = ExifTag.Software,

        /// <summary>
        ///
        /// </summary>
        SpatialFrequencyResponse = ExifTag.SpatialFrequencyResponse,

        /// <summary>
        ///
        /// </summary>
        SpectralSensitivity = ExifTag.SpectralSensitivity,

        /// <summary>
        ///
        /// </summary>
        StripByteCounts = ExifTag.StripByteCounts,

        /// <summary>
        ///
        /// </summary>
        StripOffsets = ExifTag.StripOffsets,

        /// <summary>
        ///
        /// </summary>
        SubSecTime = ExifTag.SubSecTime,

        /// <summary>
        ///
        /// </summary>
        SubSecTimeDigitized = ExifTag.SubSecTimeDigitized,

        /// <summary>
        ///
        /// </summary>
        SubSecTimeOriginal = ExifTag.SubSecTimeOriginal,

        /// <summary>
        ///
        /// </summary>
        SubfileType = ExifTag.SubfileType,

        /// <summary>
        ///
        /// </summary>
        SubjectArea = ExifTag.SubjectArea,

        /// <summary>
        ///
        /// </summary>
        SubjectDistance = ExifTag.SubjectDistance,

        /// <summary>
        ///
        /// </summary>
        SubjectDistanceRange = ExifTag.SubjectDistanceRange,

        /// <summary>
        ///
        /// </summary>
        SubjectLocation = ExifTag.SubjectLocation,

        /// <summary>
        ///
        /// </summary>
        T4Options = ExifTag.T4Options,

        /// <summary>
        ///
        /// </summary>
        T6Options = ExifTag.T6Options,

        /// <summary>
        ///
        /// </summary>
        TargetPrinter = ExifTag.TargetPrinter,

        /// <summary>
        ///
        /// </summary>
        Threshholding = ExifTag.Threshholding,

        /// <summary>
        ///
        /// </summary>
        ThumbnailArtist = ExifTag.ThumbnailArtist,

        /// <summary>
        ///
        /// </summary>
        ThumbnailBitsPerSample = ExifTag.ThumbnailBitsPerSample,

        /// <summary>
        ///
        /// </summary>
        ThumbnailCompression = ExifTag.ThumbnailCompression,

        /// <summary>
        ///
        /// </summary>
        ThumbnailCopyright = ExifTag.ThumbnailCopyright,

        /// <summary>
        ///
        /// </summary>
        ThumbnailDateTime = ExifTag.ThumbnailDateTime,

        /// <summary>
        ///
        /// </summary>
        ThumbnailImageDescription = ExifTag.ThumbnailImageDescription,

        /// <summary>
        ///
        /// </summary>
        ThumbnailImageLength = ExifTag.ThumbnailImageLength,

        /// <summary>
        ///
        /// </summary>
        ThumbnailImageWidth = ExifTag.ThumbnailImageWidth,

        /// <summary>
        ///
        /// </summary>
        ThumbnailJPEGInterchangeFormat = ExifTag.ThumbnailJPEGInterchangeFormat,

        /// <summary>
        ///
        /// </summary>
        ThumbnailJPEGInterchangeFormatLength = ExifTag.ThumbnailJPEGInterchangeFormatLength,

        /// <summary>
        ///
        /// </summary>
        ThumbnailMake = ExifTag.ThumbnailMake,

        /// <summary>
        ///
        /// </summary>
        ThumbnailModel = ExifTag.ThumbnailModel,

        /// <summary>
        ///
        /// </summary>
        ThumbnailOrientation = ExifTag.ThumbnailOrientation,

        /// <summary>
        ///
        /// </summary>
        ThumbnailPhotometricInterpretation = ExifTag.ThumbnailPhotometricInterpretation,

        /// <summary>
        ///
        /// </summary>
        ThumbnailPlanarConfiguration = ExifTag.ThumbnailPlanarConfiguration,

        /// <summary>
        ///
        /// </summary>
        ThumbnailPrimaryChromaticities = ExifTag.ThumbnailPrimaryChromaticities,

        /// <summary>
        ///
        /// </summary>
        ThumbnailReferenceBlackWhite = ExifTag.ThumbnailReferenceBlackWhite,

        /// <summary>
        ///
        /// </summary>
        ThumbnailResolutionUnit = ExifTag.ThumbnailResolutionUnit,

        /// <summary>
        ///
        /// </summary>
        ThumbnailRowsPerStrip = ExifTag.ThumbnailRowsPerStrip,

        /// <summary>
        ///
        /// </summary>
        ThumbnailSamplesPerPixel = ExifTag.ThumbnailSamplesPerPixel,

        /// <summary>
        ///
        /// </summary>
        ThumbnailSoftware = ExifTag.ThumbnailSoftware,

        /// <summary>
        ///
        /// </summary>
        ThumbnailStripByteCounts = ExifTag.ThumbnailStripByteCounts,

        /// <summary>
        ///
        /// </summary>
        ThumbnailStripOffsets = ExifTag.ThumbnailStripOffsets,

        /// <summary>
        ///
        /// </summary>
        ThumbnailTransferFunction = ExifTag.ThumbnailTransferFunction,

        /// <summary>
        ///
        /// </summary>
        ThumbnailWhitePoint = ExifTag.ThumbnailWhitePoint,

        /// <summary>
        ///
        /// </summary>
        ThumbnailXResolution = ExifTag.ThumbnailXResolution,

        /// <summary>
        ///
        /// </summary>
        ThumbnailYCbCrCoefficients = ExifTag.ThumbnailYCbCrCoefficients,

        /// <summary>
        ///
        /// </summary>
        ThumbnailYCbCrPositioning = ExifTag.ThumbnailYCbCrPositioning,

        /// <summary>
        ///
        /// </summary>
        ThumbnailYCbCrSubSampling = ExifTag.ThumbnailYCbCrSubSampling,

        /// <summary>
        ///
        /// </summary>
        ThumbnailYResolution = ExifTag.ThumbnailYResolution,

        /// <summary>
        ///
        /// </summary>
        TileByteCounts = ExifTag.TileByteCounts,

        /// <summary>
        ///
        /// </summary>
        TileLength = ExifTag.TileLength,

        /// <summary>
        ///
        /// </summary>
        TileOffsets = ExifTag.TileOffsets,

        /// <summary>
        ///
        /// </summary>
        TileWidth = ExifTag.TileWidth,

        /// <summary>
        ///
        /// </summary>
        TransferFunction = ExifTag.TransferFunction,

        /// <summary>
        ///
        /// </summary>
        TransferRange = ExifTag.TransferRange,

        /// <summary>
        ///
        /// </summary>
        UserComment = ExifTag.UserComment,

        /// <summary>
        ///
        /// </summary>
        WhiteBalance = ExifTag.WhiteBalance,

        /// <summary>
        ///
        /// </summary>
        WhitePoint = ExifTag.WhitePoint,

        /// <summary>
        ///
        /// </summary>
        WindowsAuthor = ExifTag.WindowsAuthor,

        /// <summary>
        ///
        /// </summary>
        WindowsComment = ExifTag.WindowsComment,

        /// <summary>
        ///
        /// </summary>
        WindowsKeywords = ExifTag.WindowsKeywords,

        /// <summary>
        ///
        /// </summary>
        WindowsSubject = ExifTag.WindowsSubject,

        /// <summary>
        ///
        /// </summary>
        WindowsTitle = ExifTag.WindowsTitle,

        /// <summary>
        ///
        /// </summary>
        XDensity = ExifTag.XDensity,

        /// <summary>
        ///
        /// </summary>
        XPosition = ExifTag.XPosition,

        /// <summary>
        ///
        /// </summary>
        XResolution = ExifTag.XResolution,

        /// <summary>
        ///
        /// </summary>
        YCbCrCoefficients = ExifTag.YCbCrCoefficients,

        /// <summary>
        ///
        /// </summary>
        YCbCrPositioning = ExifTag.YCbCrPositioning,

        /// <summary>
        ///
        /// </summary>
        YCbCrSubSampling = ExifTag.YCbCrSubSampling,

        /// <summary>
        ///
        /// </summary>
        YDensity = ExifTag.YDensity,

        /// <summary>
        ///
        /// </summary>
        YPosition = ExifTag.YPosition,

        /// <summary>
        ///
        /// </summary>
        YResolution = ExifTag.YResolution,

        /// <summary>
        ///
        /// </summary>
        ZerothIFDPadding = ExifTag.ZerothIFDPadding,

    }
}