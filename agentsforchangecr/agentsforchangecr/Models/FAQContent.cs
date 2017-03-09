using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace agentsforchangecr.Models
{
    public class FAQContent
    {
        public List<FAQItem> ListOfQuestions { get; set; }

        public FAQContent()
        {
            ListOfQuestions = new List<FAQItem>();
            PopulateList();
        }

        private void PopulateList()
        {
            var q1 = new FAQItem("The buyer/seller of the property picks the charity the fund are donated to. Do you have any control over that choice and are there any parameters around the gift?",
                "Total proceeds may be spread out to up to 3 charities, must be registered as a 501 (C)(3) and funds will be donated within 10 business days of close.");

            var q2 = new FAQItem("Why did Agents for Change decide to donate 10% of their commission to charity?",
                                 "We believe that owning real estate is the foundation for both personal and communal security. With that perspective in mind, a community can be strengthened through its residents and charitable programs and providing funding for those programs is vital to their success.");

            var q3 = new FAQItem("What if a seller wants to gift the 10% to an organization whose work is unpalatable to the general public?",
                                 "As long as the organization falls under the expressed guidelines, there is no issue.");

            var q4 = new FAQItem("How do I know if I am ready to purchase a home?",
                                 "Purchasing a home for the first time can be an intimidating process without the right support. We are here to help you every step of the way including home selection, financing, attorneys and more. Some basic questions you can ask yourself are do I have a steady source of income, is my existing credit score high enough, do I have enough money saved for a down payment and will I have the ability to make monthly mortgage payments. If you have questions about whether you are qualified or ready or can’t answer all those questions, we are here to help you so please call to set up an appointment with us!");

            var q5 = new FAQItem("How do we get pre-approved/pre-qualified for a mortgage?",
                                 "When it comes to mortgages there are many different options to fit each person’s specific needs. It is not as easy as just walking into your bank to apply for a mortgage. The relationship you have with your lender, to meet your specific needs is of paramount importance. We have experience with a variety of lenders and will gladly help you find the right fit so your financial needs are met. Once your needs are assessed by a licensed mortgage broker or banker they will be able to give you a clearer view of your buying power.");

            var q6 = new FAQItem("What are closing costs?",
                                 "Closings costs are attorneys or escrow fees, property taxes, interest, loan fees, title insurance, first mortgage payment and pro-rated utility costs.");

            var q7 = new FAQItem("Do we need to get a home inspection and do I need to be there for it?",
                                 "A home inspector evaluates the integrity of the homes structure, mechanical systems, construction, potential presence of pests and radon. It is important to hire a qualified home inspector with experience as they will provide you with suggested repairs and preventative maintenance on your new home. It is also important for the homebuyers to be present to see first-hand the suggestions the home inspector has for current issues and ongoing maintenance. ");

            var q8 = new FAQItem("How should I prepare my house for sale?",
                                 "It is important to declutter and depersonalize your home in preparation for your home to be sold. Doing this allows you to assess potential repairs both interior and exterior as well as well as allows your potential buyers to picture themselves living in the home. In order to make your home more marketable please as for our opinions and suggestions on what local buyers are looking for.");

            var q9 = new FAQItem("What is the best marketing strategy for selling our home?",
                                 "At Agents for Change we aggressively market our clients’ properties for a timely sale at a fair market value. We will use local publications, social media, the multiple listing service (MLS) and other creative platforms that it is necessary to sell your home. Each sub-market and home deserves its own unique plan and we are willing and able to provide that to our clients.  ");

            var q10 = new FAQItem("How do we decide on a sales price for our home?",
                                 "Many factors go into determining a listing price for your home; comparable recently sold properties in the same area, current inventory, prevailing market trends, along with area specific factors.  Before calling us, figuring out what your needs are and allowing us to help formulate a cooperative plan to get you to your goals is imperative. ");

            ListOfQuestions.Add(q1);
            ListOfQuestions.Add(q2);
            ListOfQuestions.Add(q3);
            ListOfQuestions.Add(q4);
            ListOfQuestions.Add(q5);
            ListOfQuestions.Add(q6);
            ListOfQuestions.Add(q7);
            ListOfQuestions.Add(q8);
            ListOfQuestions.Add(q9);
            ListOfQuestions.Add(q10);
        }
    }

    public class FAQItem
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public FAQItem(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}