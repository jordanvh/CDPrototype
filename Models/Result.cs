using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Central_Dispatch_Prototype.Models
{
    public class Result
    {
        public Location start { get; set; }
        public Location destination { get; set; }
        public Payment payout { get; set; }
        public Rating rating { get; set; }
        public String Appearance { get; set; }
        public bool Displaying { get; set; }

        public Result(String image, Location start, Location destination, Payment payout, Rating rating)
        {
            this.start = start;
            this.destination = destination;
            this.payout = payout;
            this.rating = rating;
            Displaying = false;

            //test this part
            Appearance = "<div id=\"resultContainer\" style=\"width: 348px; position: relative;\"><img style=\"width: 100%; height: 100 %; object-fit: contain;\" id=\"result\" src=\"" + image + "\"><div class=\"bottom-left\"><button class=\"btn btn-secondary\" id=\"requester\" data-toggle=\"modal\" data-target=\"#myModal\">Request</button></div></div>";
        }
    }
}