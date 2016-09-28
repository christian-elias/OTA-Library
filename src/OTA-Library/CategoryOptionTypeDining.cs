namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CategoryOptionTypeDining
    {
        
        private string _sitting;
        
        private string _status;
        
        private string _occupancy;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sitting
        {
            get
            {
                return this._sitting;
            }
            set
            {
                this._sitting = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Occupancy
        {
            get
            {
                return this._occupancy;
            }
            set
            {
                this._occupancy = value;
            }
        }
    }
}