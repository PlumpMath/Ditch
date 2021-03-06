using System;
using Newtonsoft.Json;

namespace Ditch.Golos.Objects
{
    /// <summary>
    /// beneficiary_route_type
    /// libraries\protocol\include\golos\protocol\operations\comment_operations.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class BeneficiaryRouteType
    {

        /// <summary>
        /// API name: account
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("account")]
        public string Account {get; set;}

        /// <summary>
        /// API name: weight
        /// 
        /// </summary>
        /// <returns>API type: uint16_t</returns>
        [JsonProperty("weight")]
        public UInt16 Weight {get; set;}
    }
}
