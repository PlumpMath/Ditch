﻿using Ditch.Golos.Enums;
using Newtonsoft.Json;

namespace Ditch.Golos.Objects
{
    /// <summary>
    /// follow_api_obj
    /// golos-0.16.3\libraries\plugins\follow\include\steemit\follow\follow_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class FollowApiObj
    {

        // bdType : string
        [JsonProperty("follower")]
        public string Follower { get; set; }

        // bdType : string
        [JsonProperty("following")]
        public string Following { get; set; }

        // bdType : vector<follow_type>
        [JsonProperty("what")]
        public FollowType[] What { get; set; }
    }
}