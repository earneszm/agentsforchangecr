using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace agentsforchangecr.Models
{
    public class TestimonialContent
    {
        public List<string> DavesTestimonials { get; set; }
        public List<string> JimsTestimonials { get; set; }

        public TestimonialContent()
        {
            DavesTestimonials = new List<string>();
            JimsTestimonials = new List<string>();

            PopulateLists();
        }

        private void PopulateLists()
        {
            var d1 = "David, has the skills and most importantly the drive required to be a productive and successful representative. He responds quickly to any request made of him and always left us with the feeling that he was looking out for our interest, not just trying to make a sale. He is a credit to his chosen profession and I would recommend him without reservation. Any agency fortunate enough to secure his services should consider themselves very lucky indeed!";
            var d2 = "Quite simply, David goes above and beyond your average representative. While I have not yet purchased a property with him, he has represented me in my search for a home in the Saratoga area. He is highly motivated, professional and extremely knowledgable of both the area and the transaction process. I highly recommend David, as anyone would be well-served to have him acting as their agent. He is the most sincere, straightforward, and honest real estate salesperson I have ever experienced.";
            var d3 = "David was very professional and a great pleasure to work with.  His help in all aspects of the sale of my house was invaluable. He not only helped me to obtain a sales agent for the contents of my home but he assisted me in ensuring the house was ready for sale on the closing day as I was not living in the vicinity. I would highly recommend David for the sale of a home and would certainly enlist his services when I look for a home in the area.";

            DavesTestimonials.Add(d1);
            DavesTestimonials.Add(d2);
            DavesTestimonials.Add(d3);

            var j1 = "James was a very professional realtor who listened to our wants and needs. He was honest and upfront about everything and anything. He wouldn't settle unless we were happy and we were in the home that \"we\" wanted. Throughout the process he guided us through each step and was able to answer all of our questions. He is very familiar with the area and is very trustworthy. I would highly recommend James for the sale and purchase of one's home.";
            var j2 = "Jim was very thorough and professional during our sale and purchase of our new home. He is very honest and knowledgeable about market values, and made sure we were listing our home to receive the best sales price. He also ensured we not only found a new home, but a new home we loved and have been happy with the last two years. Some agents look to get a sale or purchase as quickly as possible to move on to the next client, Jim was patient and always had our best interest in mind.";
            var j3 = "I was impressed with James ability to locate homes with our specific requirements to view, and his local knowledge of the market was very comforting for us moving to a new neighborhood. He was always available by phone and completely honest with us from day one, no sugar coating at all. His negotiation suggestions were spot on. Had we not listened to him, there is a very good chance we would not be living in the home of our dreams right now. Post contract, he kept us abreast of all the comings and goings and assured us every step of the way that he would do whatever is needed to help the sale go through. I would recommend James to anyone looking to buy or sell in and around the greater capital region. His honest approach is a breath of fresh air in an industry that can lend itself to spin and false assurances. I came away from my experience with James feeling far more than satisfied and would definitely work with him again.";

            JimsTestimonials.Add(j1);
            JimsTestimonials.Add(j2);
            JimsTestimonials.Add(j3);
        }
    }
}