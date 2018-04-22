using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    interface IProduct
    {
        int Id { get; set; }        //Our local Id.
        int Barcode { get; set; }   

        string Name { get; set; }
        string Description { get; set; }

        //Related for another files, each one of them are managing each option.
        //For example, there is a class (and file) that contains all the comments, and the Id here is the Id of the first comment.
        int ManufacturereId { get; set; } //Local Manufacturer Id.
        int Comments { get; set; } //Local first comment.
        int Activity { get; set; } //Local activity history (who edit, who changed it's status.., who added).

        int[] AvarageMonthlyPrice { get; set; } //Avarage prices for the last month
        int[] AvarageYearlyPrice { get; set; } //Avarage prices for the last year

        string Tags { get; set; } //Tags
        string Images { get; set; } //Path for images. Example :"http://www.dddd.com/fg.jpg, ..//dd.jpg";

        DateTime TimeAdded { get; set; }

        bool Showing { get; set; } //Is the product availavble for everyone to see?


    }
}
