using FellowOakDicom;

namespace XunitRepro;

public class ReproTests
{
    [Theory]
    [InlineData("")]
    [InlineData("gibberish")]
    public void Test1(string input)
    {
        // Contents omitted
    }

    private static readonly ISet<DicomTag> TagsSet = new []
    {
        DicomTag.AcquisitionUID,
        DicomTag.AffectedSOPInstanceUID,
        DicomTag.AnnotationGroupUID,
        DicomTag.ConcatenationUID,
        DicomTag.ConceptualVolumeUID,
        DicomTag.ConstituentConceptualVolumeUID,
        DicomTag.DeviceUID,
        DicomTag.DigitalSignatureUID,
        DicomTag.DimensionOrganizationUID,
        DicomTag.DoseReferenceUID,
        DicomTag.DosimetricObjectiveUID,
        DicomTag.FailedSOPInstanceUIDList,
        DicomTag.FiducialUID,
        DicomTag.FrameOfReferenceUID,
        DicomTag.InstanceCreatorUID,
        DicomTag.IrradiationEventUID,
        DicomTag.LargePaletteColorLookupTableUIDRETIRED,
        DicomTag.ManufacturerDeviceClassUID,
        DicomTag.MediaStorageSOPInstanceUID,
        DicomTag.MultiplexGroupUID,
        DicomTag.ObservationSubjectUIDTrialRETIRED,
        DicomTag.ObservationUID,
        DicomTag.PaletteColorLookupTableUID,
        DicomTag.PatientSetupUIDRETIRED,
        DicomTag.PresentationDisplayCollectionUID,
        DicomTag.PresentationSequenceCollectionUID,
        DicomTag.PyramidUID,
        DicomTag.ReferencedConceptualVolumeUID,
        DicomTag.ReferencedDoseReferenceUID,
        DicomTag.ReferencedDosimetricObjectiveUID,
        DicomTag.ReferencedFiducialsUID,
        DicomTag.ReferencedFrameOfReferenceUID,
        DicomTag.ReferencedGeneralPurposeScheduledProcedureStepTransactionUIDRETIRED,
        DicomTag.ReferencedObservationUIDTrialRETIRED,
        DicomTag.ReferencedSOPInstanceUID,
        DicomTag.ReferencedSOPInstanceUIDInFile,
        DicomTag.ReferencedTreatmentPositionGroupUID,
        DicomTag.RelatedFrameOfReferenceUIDRETIRED,
        DicomTag.RequestedSOPInstanceUID,
        DicomTag.RTTreatmentPhaseUID,
        DicomTag.SeriesInstanceUID,
        DicomTag.SOPInstanceUID,
        DicomTag.SourceConceptualVolumeUID,
        DicomTag.SpecimenUID,
        DicomTag.StorageMediaFileSetUID,
        DicomTag.StudyInstanceUID,
        DicomTag.SynchronizationFrameOfReferenceUID,
        DicomTag.TargetUID,
        DicomTag.TemplateExtensionCreatorUIDRETIRED,
        DicomTag.TemplateExtensionOrganizationUIDRETIRED,
        DicomTag.TrackingUID,
        DicomTag.TransactionUID,
        DicomTag.TreatmentPositionGroupUID,
        DicomTag.TreatmentSessionUID,
        DicomTag.UID
    }.ToHashSet();

    public static readonly TheoryData<DicomTag> Tags = TagsSet.Aggregate(
        new TheoryData<DicomTag>(), (data, tag) =>
        {
            data.Add(tag);
            return data;
        });

    [Theory]
    [MemberData(nameof(Tags))]
    public async Task DicomTagTest(DicomTag tag)
    {
        // Contents omitted

    }

    public static TheoryData<DicomUID> DicomUIDs =>
        new TheoryData<DicomUID>
        {
            //The public SOP Class UIDs
            DicomUID.HardcopyGrayscaleImageStorageRETIRED,
            DicomUID.HardcopyColorImageStorageRETIRED,
            DicomUID.ComputedRadiographyImageStorage,
            DicomUID.DigitalXRayImageStorageForPresentation,
            DicomUID.DigitalXRayImageStorageForProcessing,
            DicomUID.DigitalMammographyXRayImageStorageForPresentation,
            DicomUID.DigitalMammographyXRayImageStorageForProcessing,
            DicomUID.DigitalIntraOralXRayImageStorageForPresentation,
            DicomUID.DigitalIntraOralXRayImageStorageForProcessing,
            DicomUID.CTImageStorage,
            DicomUID.EnhancedCTImageStorage,
            DicomUID.LegacyConvertedEnhancedCTImageStorage,
            DicomUID.UltrasoundMultiFrameImageStorageRetiredRETIRED,
            DicomUID.UltrasoundMultiFrameImageStorage,
            DicomUID.MRImageStorage,
            DicomUID.EnhancedMRImageStorage,
            DicomUID.EnhancedMRColorImageStorage,
            DicomUID.LegacyConvertedEnhancedMRImageStorage,
            DicomUID.NuclearMedicineImageStorageRetiredRETIRED,
            DicomUID.UltrasoundImageStorageRetiredRETIRED,
            DicomUID.UltrasoundImageStorage,
            DicomUID.SecondaryCaptureImageStorage,
            DicomUID.MultiFrameSingleBitSecondaryCaptureImageStorage,
            DicomUID.MultiFrameGrayscaleByteSecondaryCaptureImageStorage,
            DicomUID.MultiFrameGrayscaleWordSecondaryCaptureImageStorage,
            DicomUID.MultiFrameTrueColorSecondaryCaptureImageStorage,
            DicomUID.XRayAngiographicImageStorage,
            DicomUID.EnhancedXAImageStorage,
            DicomUID.XRayRadiofluoroscopicImageStorage,
            DicomUID.EnhancedXRFImageStorage,
            DicomUID.XRayAngiographicBiPlaneImageStorageRETIRED,
            DicomUID.XRay3DAngiographicImageStorage,
            DicomUID.XRay3DCraniofacialImageStorage,
            DicomUID.BreastTomosynthesisImageStorage,
            DicomUID.BreastProjectionXRayImageStorageForPresentation,
            DicomUID.BreastProjectionXRayImageStorageForProcessing,
            DicomUID.IntravascularOpticalCoherenceTomographyImageStorageForPresentation,
            DicomUID.IntravascularOpticalCoherenceTomographyImageStorageForProcessing,
            DicomUID.NuclearMedicineImageStorage,
            DicomUID.VLImageStorageTrialRETIRED,
            DicomUID.VLMultiFrameImageStorageTrialRETIRED,
            DicomUID.VLEndoscopicImageStorage,
            DicomUID.VideoEndoscopicImageStorage,
            DicomUID.VLMicroscopicImageStorage,
            DicomUID.VideoMicroscopicImageStorage,
            DicomUID.VLSlideCoordinatesMicroscopicImageStorage,
            DicomUID.VLPhotographicImageStorage,
            DicomUID.VideoPhotographicImageStorage,
            DicomUID.OphthalmicPhotography8BitImageStorage,
            DicomUID.OphthalmicPhotography16BitImageStorage,
            DicomUID.OphthalmicTomographyImageStorage,
            DicomUID.WideFieldOphthalmicPhotographyStereographicProjectionImageStorage,
            DicomUID.WideFieldOphthalmicPhotography3DCoordinatesImageStorage,
            DicomUID.OphthalmicOpticalCoherenceTomographyEnFaceImageStorage,
            DicomUID.VLWholeSlideMicroscopyImageStorage,
            DicomUID.DermoscopicPhotographyImageStorage,
            DicomUID.PositronEmissionTomographyImageStorage,
            DicomUID.LegacyConvertedEnhancedPETImageStorage,
            DicomUID.EnhancedPETImageStorage,
            DicomUID.RTImageStorage,
            DicomUID.DICOSCTImageStorage,
            DicomUID.DICOSDigitalXRayImageStorageForPresentation,
            DicomUID.DICOSDigitalXRayImageStorageForProcessing,
            DicomUID.EddyCurrentImageStorage,
            DicomUID.EddyCurrentMultiFrameImageStorage,

            //The private SOP Class UIDs
            DicomUID.PrivateFujiCRImageStorage,
            DicomUID.PrivatePhilipsCTSyntheticImageStorage,
            DicomUID.PrivatePhilipsCXImageStorage,
            DicomUID.PrivatePhilipsCXSyntheticImageStorage,
            DicomUID.PrivatePhilipsMRColorImageStorage,
            DicomUID.PrivatePhilipsMRSyntheticImageStorage,
            DicomUID.PrivatePhilipsPerfusionImageStorage,
            DicomUID.PrivatePixelMedFloatingPointImageStorage,
            DicomUID.PrivatePixelMedLegacyConvertedEnhancedCTImageStorage,
            DicomUID.PrivatePixelMedLegacyConvertedEnhancedMRImageStorage,
            DicomUID.PrivatePixelMedLegacyConvertedEnhancedPETImageStorage,
            DicomUID.PrivatePMODMultiFrameImageStorage,
            DicomUID.PrivateToshibaUSImageStorage,
            DicomUID.PrivateSiemensCSANonImageStorage,
        };

    [Theory]
    [MemberData(nameof(DicomUIDs))]
    public void DicomUIDTest(DicomUID dicomUID)
    {
        // Contents omitted
    }

    [Theory]
    [InlineData("20221129", "143800", 2022, 11, 29, 14, 38, 00)]
    [InlineData("20181008", "125500", 2018, 10, 08, 12, 55, 00)]
    [InlineData("19950131", "095512", 1995, 01, 31, 09, 55, 12)]
    [InlineData("19000102", "000001", 1900, 01, 02, 00, 00, 01)]
    [InlineData("20781231", "235959", 2078, 12, 31, 23, 59, 59)]
    public void DateTimeTest(string studyDate, string studyTime, int expectedYear, int expectedMonth, int expectedDay, int expectedHour, int expectedMinute, int expectedSecond)
    {
        // Contents omitted
    }
}
