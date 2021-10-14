using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class_Implementation
{
   partial class LMS : IAsessment
   {
        
        string name;
        int SNO;
        long mobilenum;
        string email;

        public void Display()
        void IAsessment.MCQ_Asessment()

            void IAsessment.QuestionBank()
        {

        }

        
       

   }
    partial class LMS : Placement, Asessment //inheritance
    {
        public void Message()
        {

            Console.WriteLine("This Message is coming from second implementation of class");
        }


    }
    abstract class Placement
    {
        string Name_Of_Company;
        int No_Of_Student_Placed;
        DateTime Year_Of_Placement;

       public void Placement_record()
        {
            Console.WriteLine("This method will show you complete record of the placement");
        }
    }
     interface IAsessment
    {

        //int Asessment_Count; creating instance field is not allowed

        public void MCQ_Asessment();

        public void QuestionBank();


    }

}
