namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ET_FareInfoRuleIndicator
    {
        
        private string _ruleCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleCode
        {
            get
            {
                return this._ruleCode;
            }
            set
            {
                this._ruleCode = value;
            }
        }
    }
}