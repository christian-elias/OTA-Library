namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MessageTypeOriginalPayloadStdAttributes
    {
        
        private string _echoToken;
        
        private System.DateTime _timeStamp;
        
        private MessageAcknowledgementTypeTarget _target;
        
        private string _targetName;
        
        private decimal _version;
        
        private string _transactionIdentifier;
        
        private string _sequenceNmbr;
        
        private MessageAcknowledgementTypeTransactionStatusCode _transactionStatusCode;
        
        private bool _retransmissionIndicator;
        
        private string _correlationID;
        
        private string _primaryLangID;
        
        private string _altLangID;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this._echoToken;
            }
            set
            {
                this._echoToken = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this._timeStamp;
            }
            set
            {
                this._timeStamp = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MessageAcknowledgementTypeTarget Target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetName
        {
            get
            {
                return this._targetName;
            }
            set
            {
                this._targetName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionIdentifier
        {
            get
            {
                return this._transactionIdentifier;
            }
            set
            {
                this._transactionIdentifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SequenceNmbr
        {
            get
            {
                return this._sequenceNmbr;
            }
            set
            {
                this._sequenceNmbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MessageAcknowledgementTypeTransactionStatusCode TransactionStatusCode
        {
            get
            {
                return this._transactionStatusCode;
            }
            set
            {
                this._transactionStatusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RetransmissionIndicator
        {
            get
            {
                return this._retransmissionIndicator;
            }
            set
            {
                this._retransmissionIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorrelationID
        {
            get
            {
                return this._correlationID;
            }
            set
            {
                this._correlationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string PrimaryLangID
        {
            get
            {
                return this._primaryLangID;
            }
            set
            {
                this._primaryLangID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string AltLangID
        {
            get
            {
                return this._altLangID;
            }
            set
            {
                this._altLangID = value;
            }
        }
    }
}