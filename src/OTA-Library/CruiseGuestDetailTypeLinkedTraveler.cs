namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestDetailTypeLinkedTraveler : RelatedTravelerType
    {
        
        private string _linkTypeCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LinkTypeCode
        {
            get
            {
                return this._linkTypeCode;
            }
            set
            {
                this._linkTypeCode = value;
            }
        }
    }
}