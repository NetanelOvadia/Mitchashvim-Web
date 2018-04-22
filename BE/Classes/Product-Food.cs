using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Product_Food : IProduct
    {
        public int Id { get; set; }        //Our local Id.
        public int Barcode { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        //Related for another files, each one of them are managing each option.
        //For example, there is a class (and file) that contains all the comments, and the Id here is the Id of the first comment.
        public int ManufacturereId { get; set; } //Local Manufacturer Id.
        public int Comments { get; set; } //Local first comment.
        public int Activity { get; set; } //Local activity history (who edit, who changed it's status.., who added).

        public int[] AvarageMonthlyPrice { get; set; } //Avarage prices for the last month
        public int[] AvarageYearlyPrice { get; set; } //Avarage prices for the last year

        public string Tags { get; set; } //Tags
        public string Images { get; set; } //Path for images. Example :"http://www.dddd.com/fg.jpg, ..//dd.jpg";

        public DateTime TimeAdded { get; set; }

        public bool Showing { get; set; } //Is the product availavble for everyone to see?

        public string Ingredients { get; set; } //Like: "Sugar 50%, Water 30%"
        public string NutritionalValues { get; set; } //Like: "100Mg, Calories < 0.5, Sodium 180";


    }
}
