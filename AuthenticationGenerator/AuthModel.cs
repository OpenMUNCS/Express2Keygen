using System.Xml.Serialization;

namespace AuthenticationGenerator
{
    [XmlRoot("Message")]
    public class AuthModel
    {
        public string Version { get; set; }
        public string EncPrimitives { get; set; }
        public string SignPrimitives { get; set; }
        public string MACPrimitives { get; set; }
        public string MasterKeyHash { get; set; }
        public string Type { get; set; }
        public string Target { get; set; }
        public string MainBody { get; set; }
        public bool IsSubsidiaryBodyLocked { get; set; }
        public string SubsidiaryBodies { get; set; }
        public string TimeStart { get; set; }
        public int TimeSustain { get; set; }
        public string ExpressService { get; set; }
        public string NyarlathotepService { get; set; }
        public string NotesService { get; set; }
        public string ProsService { get; set; }
        public string InfonetService { get; set; }
        public bool IsCoreUser { get; set; }
        public bool IsPayingUser { get; set; }
        public int AdvancedSupport { get; set; }
        public bool IsOverseasService { get; set; }
        public string Region { get; set; }
        public string Comments { get; set; }
    }
}
