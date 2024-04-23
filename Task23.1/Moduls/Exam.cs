using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23._1.Moduls
{
    internal class Exam
    {
        public string Subject {  get; set; }
        public int ExamDuration { get; set; }   //(nece saat devam edir onu gosterir)
        public DateTime StartDate { get; set; } = DateTime.Now;  //(DateTime ile dinamik teyin olunur)
        public DateTime EndDate { get; set; }  //(DateTime ile dinamik teyin olunur Startin ustune durationu gelirsiz)

        public Exam(string subject,int examDuration,DateTime startDate )
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate = startDate;
            
           
        }
        public void Start()
        {
            StartDate = DateTime.Now; 
        }
    }
}
