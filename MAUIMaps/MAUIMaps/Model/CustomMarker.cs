﻿namespace MAUIMaps
{
    using Syncfusion.Maui.Maps;

    /// <summary>
    /// Represents information about a geographic location, including its name, details, coordinates, address and image.
    /// </summary>
    public class CustomMarker : MapMarker
    {
        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets additional details about the location.
        /// </summary>
        public string? Details { get; set; }

        /// <summary>
        /// Gets or sets the address of the location.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Gets or sets the image name based on offline location.
        /// </summary>
        public string? ImageName { get; set; }

        /// <summary>
        /// Gets or sets the image uri based on location.
        /// </summary>
        public Uri? Image { get; set; }
    }
}