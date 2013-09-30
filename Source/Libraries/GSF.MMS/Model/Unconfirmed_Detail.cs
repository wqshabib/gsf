//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using GSF.ASN1;
using GSF.ASN1.Attributes;
using GSF.ASN1.Coders;
using GSF.ASN1.Types;

namespace GSF.MMS.Model
{
    [ASN1PreparedElement]
    [ASN1Choice(Name = "Unconfirmed_Detail")]
    public class Unconfirmed_Detail : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Unconfirmed_Detail));
        private CS_EventNotification eventNotification_;
        private bool eventNotification_selected;
        private NullObject otherRequests_;
        private bool otherRequests_selected;


        [ASN1Null(Name = "otherRequests")]
        [ASN1Element(Name = "otherRequests", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public NullObject OtherRequests
        {
            get
            {
                return otherRequests_;
            }
            set
            {
                selectOtherRequests(value);
            }
        }


        [ASN1Element(Name = "eventNotification", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public CS_EventNotification EventNotification
        {
            get
            {
                return eventNotification_;
            }
            set
            {
                selectEventNotification(value);
            }
        }

        public void initWithDefaults()
        {
        }

        public IASN1PreparedElementData PreparedData
        {
            get
            {
                return preparedData;
            }
        }


        public bool isOtherRequestsSelected()
        {
            return otherRequests_selected;
        }


        public void selectOtherRequests()
        {
            selectOtherRequests(new NullObject());
        }


        public void selectOtherRequests(NullObject val)
        {
            otherRequests_ = val;
            otherRequests_selected = true;


            eventNotification_selected = false;
        }


        public bool isEventNotificationSelected()
        {
            return eventNotification_selected;
        }


        public void selectEventNotification(CS_EventNotification val)
        {
            eventNotification_ = val;
            eventNotification_selected = true;


            otherRequests_selected = false;
        }
    }
}