namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleReservationRQAdditionalInfoTypeRentalPaymentPref : PaymentDetailType
    {
        
        private VehicleReservationRQAdditionalInfoTypeRentalPaymentPrefType _type;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleReservationRQAdditionalInfoTypeRentalPaymentPrefType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}