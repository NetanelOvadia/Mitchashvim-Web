using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Manufacturer
    {
        /// <summary>
        /// Local id
        /// </summary>
        public int Id { get; set; }//local
        public int ManufacturerId { get; set; } //real

        public string Name { get; set; }
        public string Address { get; set; } //of the main building.
        public string Email { get; set; } //of customer service.

        public int PhoneNumber { get; set; } //of customer service.
        public int FaxNumber { get; set; }
        public int Comments { get; set; } //id of the first comment.
        public int Activity { get; set; } //the id of the last activity.
        public int SettingId { get; set; } //if there is a specific setting for this manufacturer.

        public string LogoPath { get; set; } //path for the manufacturer logo.

    }
}
