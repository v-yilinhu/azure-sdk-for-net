// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary> Request to get instances by Time Series Ids. </summary>
    public partial class InstancesBatchGetByIdsRequest
    {
        /// <summary> Initializes a new instance of InstancesBatchGetByIdsRequest. </summary>
        public InstancesBatchGetByIdsRequest()
        {
        }

        /// <summary> Time series IDs of time series instances to return. </summary>
        public InstancesRequestBatchByIds Get { get; set; }
    }
}
