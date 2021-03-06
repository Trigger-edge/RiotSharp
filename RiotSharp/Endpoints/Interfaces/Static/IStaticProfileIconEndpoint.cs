﻿using RiotSharp.Endpoints.StaticDataEndpoint.ProfileIcons;
using RiotSharp.Misc;
using System.Threading.Tasks;

namespace RiotSharp.Endpoints.Interfaces.Static
{
    public interface IStaticProfileIconEndpoint : IStaticEndpoint
    {
        /// <summary>
        /// Get a list of profile icons asynchronously
        /// </summary>
        /// <param name="region">Region corresponding to data to retrieve.</param>
        /// <param name="language">>Language of the data to be retrieved.</param>
        /// <param name="version">Patch version for returned data. If not specified, the latest version for the region is used. 
        /// List of valid versions can be obtained from the /versions endpoint.</param>
        /// <returns>A ProfileIconListStatic object containing all runes.</returns>
        Task<ProfileIconListStatic> GetProfileIconsAsync(Region region, Language language = Language.en_US,
            string version = null);
    }
}