using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace S00266759OODMayExam2026
{
    public class TrainingSession
    {

        public int TrainingSessionId { get; set; } //PK (Primary Key)
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public int DurationMinutes { get; set; }
        public string CoachNotes { get; set; }

        public int MemberId { get; set; } //FK (Foreign Key)

        //Navagation property to Member
        public virtual Member Member { get; set; } 
        
    }
}
