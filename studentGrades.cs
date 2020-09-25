using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Web;

namespace Web_App_Unit_7
{
    public class studentGrades
    {
        private ArrayList GradeList;

        public int MaxGrade = 0;
        public int MinGrade = 100;
        public int AvgGrade = 0;

        public studentGrades()
        {
            GradeList = new ArrayList();
        }
        public studentGrades(string gradefileName)
        {
            GradeList = new ArrayList();
            ReadGradeDataFromXML(gradefileName);
            AvgGrade = CalculateAverage();
            MaxGrade = CalculateMax();
            MinGrade = CalculateMin();
        }

        private void addGrade(int aGrade)
        {
            GradeList.Add(aGrade);
        }
        private int CalculateMin()
        {
            GradeList.Sort();
            int min = (int)GradeList[0];
            return min;
        }

        private int CalculateMax()
        {
            GradeList.Sort();
            int max = (int)GradeList[GradeList.Count - 1];
            return max;
        }

        private int CalculateAverage()
        {
            int avg = 0;
            int sum = 0;
            foreach (int grade in GradeList)
            {
                sum = sum + grade;
            }
            avg = sum / GradeList.Count;
            return avg;
        }
        private void ReadGradeDataFromXML(string gradefileName)
        {
            XmlTextReader reader = new XmlTextReader(gradefileName);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        System.Diagnostics.Debug.Write("<" + reader.Name);
                        System.Diagnostics.Debug.Write(">");
                        break;
                    case XmlNodeType.Text:
                        System.Diagnostics.Debug.Write(reader.Value);
                        int val = Convert.ToInt32(reader.Value);
                        addGrade(val);
                        break;
                    case XmlNodeType.EndElement:
                        System.Diagnostics.Debug.Write("</" + reader.Name);
                        System.Diagnostics.Debug.Write(">");
                        break;
                }
            }
        }
    }
}