//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System.Collections.Generic;
using GSF.ASN1;
using GSF.ASN1.Attributes;
using GSF.ASN1.Coders;
using GSF.ASN1.Types;

namespace GSF.MMS.Model
{

    [ASN1PreparedElement]
    [ASN1Sequence(Name = "Access_Control_List_instance", IsSet = false)]
    public class Access_Control_List_instance : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Access_Control_List_instance));
        private DefinitionChoiceType definition_;
        private Identifier name_;

        [ASN1Element(Name = "name", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public Identifier Name
        {
            get
            {
                return name_;
            }
            set
            {
                name_ = value;
            }
        }


        [ASN1Element(Name = "definition", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public DefinitionChoiceType Definition
        {
            get
            {
                return definition_;
            }
            set
            {
                definition_ = value;
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

        [ASN1PreparedElement]
        [ASN1Choice(Name = "definition")]
        public class DefinitionChoiceType : IASN1PreparedElement
        {
            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(DefinitionChoiceType));
            private DetailsSequenceType details_;
            private bool details_selected;
            private ObjectIdentifier reference_;
            private bool reference_selected;


            [ASN1ObjectIdentifier(Name = "")]
            [ASN1Element(Name = "reference", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
            public ObjectIdentifier Reference
            {
                get
                {
                    return reference_;
                }
                set
                {
                    selectReference(value);
                }
            }


            [ASN1Element(Name = "details", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
            public DetailsSequenceType Details
            {
                get
                {
                    return details_;
                }
                set
                {
                    selectDetails(value);
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


            public bool isReferenceSelected()
            {
                return reference_selected;
            }


            public void selectReference(ObjectIdentifier val)
            {
                reference_ = val;
                reference_selected = true;


                details_selected = false;
            }


            public bool isDetailsSelected()
            {
                return details_selected;
            }


            public void selectDetails(DetailsSequenceType val)
            {
                details_ = val;
                details_selected = true;


                reference_selected = false;
            }

            [ASN1PreparedElement]
            [ASN1Sequence(Name = "details", IsSet = false)]
            public class DetailsSequenceType : IASN1PreparedElement
            {
                private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(DetailsSequenceType));
                private ICollection<Access_Control_List_instance> accessControlLists_;
                private Access_Control_List_instance accessControl_;
                private ICollection<Data_Exchange_instance> dataExchanges_;
                private AccessCondition deleteAccessCondition_;

                private bool deleteAccessCondition_present;
                private ICollection<Domain_instance> domains_;
                private AccessCondition editAccessCondition_;

                private bool editAccessCondition_present;
                private ICollection<Event_Action_instance> eventActions_;
                private ICollection<Event_Condition_List_instance> eventConditionLists_;
                private ICollection<Event_Condition_instance> eventConditions_;
                private ICollection<Event_Enrollment_instance> eventEnrollments_;
                private AccessCondition executeAccessCondition_;

                private bool executeAccessCondition_present;
                private ICollection<Journal_instance> journals_;
                private AccessCondition loadAccessCondition_;

                private bool loadAccessCondition_present;
                private ICollection<Named_Type_instance> namedTypes_;
                private ICollection<Named_Variable_List_instance> namedVariableLists_;
                private ICollection<Named_Variable_instance> namedVariables_;
                private ICollection<Operator_Station_instance> operatorStations_;
                private ICollection<Program_Invocation_instance> programInvocations_;


                private AccessCondition readAccessCondition_;

                private bool readAccessCondition_present;
                private ICollection<Semaphore_instance> semaphores_;


                private AccessCondition storeAccessCondition_;

                private bool storeAccessCondition_present;
                private ICollection<Unit_Control_instance> unitControls_;
                private ICollection<Unnamed_Variable_instance> unnamedVariables_;


                private AccessCondition writeAccessCondition_;

                private bool writeAccessCondition_present;

                [ASN1Element(Name = "accessControl", IsOptional = false, HasTag = true, Tag = 3, HasDefaultValue = false)]
                public Access_Control_List_instance AccessControl
                {
                    get
                    {
                        return accessControl_;
                    }
                    set
                    {
                        accessControl_ = value;
                    }
                }

                [ASN1Element(Name = "readAccessCondition", IsOptional = true, HasTag = true, Tag = 4, HasDefaultValue = false)]
                public AccessCondition ReadAccessCondition
                {
                    get
                    {
                        return readAccessCondition_;
                    }
                    set
                    {
                        readAccessCondition_ = value;
                        readAccessCondition_present = true;
                    }
                }

                [ASN1Element(Name = "storeAccessCondition", IsOptional = true, HasTag = true, Tag = 5, HasDefaultValue = false)]
                public AccessCondition StoreAccessCondition
                {
                    get
                    {
                        return storeAccessCondition_;
                    }
                    set
                    {
                        storeAccessCondition_ = value;
                        storeAccessCondition_present = true;
                    }
                }

                [ASN1Element(Name = "writeAccessCondition", IsOptional = true, HasTag = true, Tag = 6, HasDefaultValue = false)]
                public AccessCondition WriteAccessCondition
                {
                    get
                    {
                        return writeAccessCondition_;
                    }
                    set
                    {
                        writeAccessCondition_ = value;
                        writeAccessCondition_present = true;
                    }
                }


                [ASN1Element(Name = "loadAccessCondition", IsOptional = true, HasTag = true, Tag = 7, HasDefaultValue = false)]
                public AccessCondition LoadAccessCondition
                {
                    get
                    {
                        return loadAccessCondition_;
                    }
                    set
                    {
                        loadAccessCondition_ = value;
                        loadAccessCondition_present = true;
                    }
                }


                [ASN1Element(Name = "executeAccessCondition", IsOptional = true, HasTag = true, Tag = 8, HasDefaultValue = false)]
                public AccessCondition ExecuteAccessCondition
                {
                    get
                    {
                        return executeAccessCondition_;
                    }
                    set
                    {
                        executeAccessCondition_ = value;
                        executeAccessCondition_present = true;
                    }
                }


                [ASN1Element(Name = "deleteAccessCondition", IsOptional = true, HasTag = true, Tag = 9, HasDefaultValue = false)]
                public AccessCondition DeleteAccessCondition
                {
                    get
                    {
                        return deleteAccessCondition_;
                    }
                    set
                    {
                        deleteAccessCondition_ = value;
                        deleteAccessCondition_present = true;
                    }
                }


                [ASN1Element(Name = "editAccessCondition", IsOptional = true, HasTag = true, Tag = 10, HasDefaultValue = false)]
                public AccessCondition EditAccessCondition
                {
                    get
                    {
                        return editAccessCondition_;
                    }
                    set
                    {
                        editAccessCondition_ = value;
                        editAccessCondition_present = true;
                    }
                }


                [ASN1SequenceOf(Name = "accessControlLists", IsSetOf = false)]
                [ASN1Element(Name = "accessControlLists", IsOptional = false, HasTag = true, Tag = 11, HasDefaultValue = false)]
                public ICollection<Access_Control_List_instance> AccessControlLists
                {
                    get
                    {
                        return accessControlLists_;
                    }
                    set
                    {
                        accessControlLists_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "domains", IsSetOf = false)]
                [ASN1Element(Name = "domains", IsOptional = false, HasTag = true, Tag = 12, HasDefaultValue = false)]
                public ICollection<Domain_instance> Domains
                {
                    get
                    {
                        return domains_;
                    }
                    set
                    {
                        domains_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "programInvocations", IsSetOf = false)]
                [ASN1Element(Name = "programInvocations", IsOptional = false, HasTag = true, Tag = 13, HasDefaultValue = false)]
                public ICollection<Program_Invocation_instance> ProgramInvocations
                {
                    get
                    {
                        return programInvocations_;
                    }
                    set
                    {
                        programInvocations_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "unitControls", IsSetOf = false)]
                [ASN1Element(Name = "unitControls", IsOptional = false, HasTag = true, Tag = 14, HasDefaultValue = false)]
                public ICollection<Unit_Control_instance> UnitControls
                {
                    get
                    {
                        return unitControls_;
                    }
                    set
                    {
                        unitControls_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "unnamedVariables", IsSetOf = false)]
                [ASN1Element(Name = "unnamedVariables", IsOptional = false, HasTag = true, Tag = 15, HasDefaultValue = false)]
                public ICollection<Unnamed_Variable_instance> UnnamedVariables
                {
                    get
                    {
                        return unnamedVariables_;
                    }
                    set
                    {
                        unnamedVariables_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "namedVariables", IsSetOf = false)]
                [ASN1Element(Name = "namedVariables", IsOptional = false, HasTag = true, Tag = 16, HasDefaultValue = false)]
                public ICollection<Named_Variable_instance> NamedVariables
                {
                    get
                    {
                        return namedVariables_;
                    }
                    set
                    {
                        namedVariables_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "namedVariableLists", IsSetOf = false)]
                [ASN1Element(Name = "namedVariableLists", IsOptional = false, HasTag = true, Tag = 17, HasDefaultValue = false)]
                public ICollection<Named_Variable_List_instance> NamedVariableLists
                {
                    get
                    {
                        return namedVariableLists_;
                    }
                    set
                    {
                        namedVariableLists_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "namedTypes", IsSetOf = false)]
                [ASN1Element(Name = "namedTypes", IsOptional = false, HasTag = true, Tag = 18, HasDefaultValue = false)]
                public ICollection<Named_Type_instance> NamedTypes
                {
                    get
                    {
                        return namedTypes_;
                    }
                    set
                    {
                        namedTypes_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "dataExchanges", IsSetOf = false)]
                [ASN1Element(Name = "dataExchanges", IsOptional = false, HasTag = true, Tag = 19, HasDefaultValue = false)]
                public ICollection<Data_Exchange_instance> DataExchanges
                {
                    get
                    {
                        return dataExchanges_;
                    }
                    set
                    {
                        dataExchanges_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "semaphores", IsSetOf = false)]
                [ASN1Element(Name = "semaphores", IsOptional = false, HasTag = true, Tag = 20, HasDefaultValue = false)]
                public ICollection<Semaphore_instance> Semaphores
                {
                    get
                    {
                        return semaphores_;
                    }
                    set
                    {
                        semaphores_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "operatorStations", IsSetOf = false)]
                [ASN1Element(Name = "operatorStations", IsOptional = false, HasTag = true, Tag = 21, HasDefaultValue = false)]
                public ICollection<Operator_Station_instance> OperatorStations
                {
                    get
                    {
                        return operatorStations_;
                    }
                    set
                    {
                        operatorStations_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "eventConditions", IsSetOf = false)]
                [ASN1Element(Name = "eventConditions", IsOptional = false, HasTag = true, Tag = 22, HasDefaultValue = false)]
                public ICollection<Event_Condition_instance> EventConditions
                {
                    get
                    {
                        return eventConditions_;
                    }
                    set
                    {
                        eventConditions_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "eventActions", IsSetOf = false)]
                [ASN1Element(Name = "eventActions", IsOptional = false, HasTag = true, Tag = 23, HasDefaultValue = false)]
                public ICollection<Event_Action_instance> EventActions
                {
                    get
                    {
                        return eventActions_;
                    }
                    set
                    {
                        eventActions_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "eventEnrollments", IsSetOf = false)]
                [ASN1Element(Name = "eventEnrollments", IsOptional = false, HasTag = true, Tag = 24, HasDefaultValue = false)]
                public ICollection<Event_Enrollment_instance> EventEnrollments
                {
                    get
                    {
                        return eventEnrollments_;
                    }
                    set
                    {
                        eventEnrollments_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "journals", IsSetOf = false)]
                [ASN1Element(Name = "journals", IsOptional = false, HasTag = true, Tag = 25, HasDefaultValue = false)]
                public ICollection<Journal_instance> Journals
                {
                    get
                    {
                        return journals_;
                    }
                    set
                    {
                        journals_ = value;
                    }
                }


                [ASN1SequenceOf(Name = "eventConditionLists", IsSetOf = false)]
                [ASN1Element(Name = "eventConditionLists", IsOptional = false, HasTag = true, Tag = 26, HasDefaultValue = false)]
                public ICollection<Event_Condition_List_instance> EventConditionLists
                {
                    get
                    {
                        return eventConditionLists_;
                    }
                    set
                    {
                        eventConditionLists_ = value;
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


                public bool isReadAccessConditionPresent()
                {
                    return readAccessCondition_present;
                }

                public bool isStoreAccessConditionPresent()
                {
                    return storeAccessCondition_present;
                }

                public bool isWriteAccessConditionPresent()
                {
                    return writeAccessCondition_present;
                }

                public bool isLoadAccessConditionPresent()
                {
                    return loadAccessCondition_present;
                }

                public bool isExecuteAccessConditionPresent()
                {
                    return executeAccessCondition_present;
                }

                public bool isDeleteAccessConditionPresent()
                {
                    return deleteAccessCondition_present;
                }

                public bool isEditAccessConditionPresent()
                {
                    return editAccessCondition_present;
                }
            }
        }
    }
}