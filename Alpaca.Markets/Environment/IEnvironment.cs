﻿using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Provides URLs for different APIs available for this SDK on specific environment.
    /// </summary>
    public interface IEnvironment
    {
        /// <summary>
        /// Gets Alpaca trading REST API base URL for this environment.
        /// </summary>
        Uri AlpacaTradingApi { get; }

        /// <summary>
        /// Gets Alpaca data REST API base URL for this environment.
        /// </summary>
        Uri AlpacaDataApi { get; }

        /// <summary>
        /// Gets Polygon.io data REST API base URL for this environment.
        /// </summary>
        [Obsolete("This property will be removed in the next major SDK release.", true)]
        Uri PolygonDataApi { get; }

        /// <summary>
        /// Gets Alpaca streaming API base URL for this environment.
        /// </summary>
        Uri AlpacaStreamingApi { get; }

        /// <summary>
        /// Gets Polygon.io streaming API base URL for this environment.
        /// </summary>
        [Obsolete("This property will be removed in the next major SDK release.", true)]
        Uri PolygonStreamingApi { get; }

        /// <summary>
        /// Gets Alpaca data streaming API base URL for this environment.
        /// </summary>
        Uri AlpacaDataStreamingApi { get; }
    }
}
