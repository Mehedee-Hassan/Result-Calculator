using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Calculator_App
{
    class ResultCalculator
    {

        private double marksPhysics ;
        private double marksChemistry;
        private double marksMath;
        private double marksAverage;



        public ResultCalculator(double marksPhysics, double marksChemistry, double marksMath)
        {
            this.marksPhysics = marksPhysics;
            this.marksChemistry = marksChemistry;
            this.marksMath = marksMath;
        }

        public ResultCalculator()
        {
            
        }


        public double MarksPhysics
        {
          set { marksPhysics = value; }
        }


        public double MarksChemistry
        {
            set { marksChemistry = value; }
        }

        public double MarksMath
        {
            set { marksMath = value; }
        }


        public double GetMarksAverage()
        {
            marksAverage =  ((marksMath + marksChemistry + marksPhysics) / 3.0);
            return marksAverage;
        }

        public string GetGradeLetter ()
        {

            marksAverage = GetMarksAverage();


            if (marksAverage >= 80)
                return "A+";
            if (marksAverage >= 70 )
                 return "B+";
            if (marksAverage >= 60)
                return "C+";
            if (marksAverage >= 50)
                return "D+";
            if (marksAverage < 50)
                return "F";


            return "No valid input Inserted";
        }

    }
}
