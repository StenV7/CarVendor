﻿using System.ComponentModel.DataAnnotations;

namespace CarVendor.Models
{
    public class Car
    {
        #region Fields and properties

        /// <summary>
        /// Gets or sets the license plate.
        /// </summary>
        /// <value>
        /// The license plate.
        /// </value>
        [LicensePlate, Key, Display(Name = "Kenteken")]
        [MaxLength(8, ErrorMessage = "{0} is een ongeldig kenteken. Mag maximaal {1} tekens bevatten")]
        public string LicensePlate { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the mark.
        /// </summary>
        /// <value>
        /// The mark.
        /// </value>
        [Display(Name = "Merk")]
        [MaxLength (50, ErrorMessage = "{0} mag niet meer dan {1} tekens bevatten")]
        public string Mark { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        [Display(Name = "Type")]
        public string Model { get; set; } = string.Empty;

        #endregion Fields and properties
    }
}