﻿//******************************************************************************************************
//  TsfDataAdapter.cs - Gbtc
//
//  Copyright © 2012, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  10/05/2012 - Adam Crain
//       Generated original version of source code.
//  12/13/2012 - Starlynn Danyelle Gilliam
//       Modified Header.
//
//******************************************************************************************************

using System.Collections.Generic;
using DNP3.Interface;
using GSF.TimeSeries;

namespace Dnp3Adapters
{
    /// <summary>
    /// This is the data adapter that converts data from the dnp3 world to the TSF
    /// </summary>
    class TimeSeriesDataObserver : IDataObserver
    {
        public delegate void OnNewMeasurements(ICollection<IMeasurement> measurements);
        public event OnNewMeasurements NewMeasurements;

        private readonly MeasurementLookup m_lookup;
        private readonly List<IMeasurement> m_Measurements = new List<IMeasurement>();

        public TimeSeriesDataObserver(MeasurementLookup lookup)
        {
            m_lookup = lookup;
        }

        public void End()
        {
            if (m_Measurements.Count > 0 && NewMeasurements != null)
            {
                NewMeasurements(m_Measurements);
            }
        }

        public void Start()
        {
            m_Measurements.Clear();
        }

        public void Update(SetpointStatus update, uint index)
        {
            IMeasurement maybeNull = m_lookup.LookupMaybeNull(update, index);
            if (maybeNull != null) m_Measurements.Add(maybeNull);

        }

        public void Update(ControlStatus update, uint index)
        {
            IMeasurement maybeNull = m_lookup.LookupMaybeNull(update, index);
            if (maybeNull != null) m_Measurements.Add(maybeNull);
        }

        public void Update(Counter update, uint index)
        {
            IMeasurement maybeNull = m_lookup.LookupMaybeNull(update, index);
            if (maybeNull != null) m_Measurements.Add(maybeNull);
        }

        public void Update(Analog update, uint index)
        {
            IMeasurement maybeNull = m_lookup.LookupMaybeNull(update, index);
            if (maybeNull != null) m_Measurements.Add(maybeNull);
        }

        public void Update(Binary update, uint index)
        {
            IMeasurement maybeNull = m_lookup.LookupMaybeNull(update, index);
            if (maybeNull != null) m_Measurements.Add(maybeNull);
        }


    }
}