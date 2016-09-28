namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ParagraphTypeListItem : FormattedTextTextType
    {
        
        private string _listItem;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string ListItem
        {
            get
            {
                return this._listItem;
            }
            set
            {
                this._listItem = value;
            }
        }
    }
}