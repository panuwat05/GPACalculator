using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAx
{
    internal class GPACalculator
    {
        private double gpa_sum = 0;
        private int n = 0;
        private double gpa_min = double.MaxValue;
        private double gpa_max = double.MinValue;
        public void setGPA(double gpa)
        {
            this.gpa_sum += gpa;
            this.n++;

            // อัปเดตค่า min และ max
            if (gpa < gpa_min) gpa_min = gpa;
        }
        public double getMaxGPA()
        {
            return (n > 0) ? this.gpa_max : 0; // ป้องกันกรณีไม่มีข้อมูล
        }
        public double getMinGPA()
        {
            return (n > 0) ? this.gpa_min : 0; // ป้องกันกรณีไม่มีข้อมูล
        }
        public double getGPAX()
        {
            return (n > 0) ? this.gpa_sum / this.n : 0; // ป้องกันการหารด้วยศูนย์
        }
        public int getStudentCount()
        {
            return this.n;
        }
    }
}
