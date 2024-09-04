﻿namespace MAUIMaps
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MarkerTemplateSelector"/> class.
    /// </summary>
    public class MarkerTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// Gets or sets the normal template.
        /// </summary>
        public DataTemplate? NormalTemplate { get; set; }

        /// <summary>
        /// Gets or sets the detail template.
        /// </summary>
        public DataTemplate? DetailTemplate { get; set; }

        /// <summary>
        /// Gets or sets the offline template.
        /// </summary>
        public DataTemplate? OfflineTemplate { get; set; }

        /// <summary>
        /// Selects a data template based on the properties of the given custom marker item.
        /// </summary>
        /// <param name="item">The custom marker item.</param>
        /// <param name="container">The bindable object.</param>
        /// <returns>Return suitable template.</returns>
        protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
        {
            var customMarker = (CustomMarker)item;
            if (customMarker.Image == null && customMarker.ImageName != string.Empty)
            {
                return OfflineTemplate;
            }
            else
            {
                return customMarker.Address == string.Empty ? NormalTemplate : DetailTemplate;
            }
        }
    }
}