using System;
using System.Collections.Generic;
using System.Text;

namespace Authority
{
    class Authorities
    {
        int Id { get; set; }
        int UserId { get; set; }
        int ClassType { get; set; } //enum Class { Authority, Activity, Chain, Comment, Manufacturer, Product, Store, User};

        bool AddAutomatic { get; set; }
        bool AddManual { get; set; }
        bool ModifyDetails { get; set; }
        bool ModifySettings { get; set; }
        bool View { get; set; }
        bool Remove { get; set; }
        bool Specific { get; set; } //Does the premission gave for a specific product / user ..

    }
}
