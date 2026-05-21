using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S00266759OODMayExam2026
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var member1 = new Member { FirstName = "Siofra", Surname = "McGloughlin", DateOfBirth = new DateTime (1989, 4, 21), ContactNumber = "3468190192", MembershipType = "standard" };
            var member2 = new Member { FirstName = "Dave", Surname = "O'Hara", DateOfBirth = new DateTime (1990, 5, 11), ContactNumber = "64918371101", MembershipType = "standard" };

            Console.WriteLine("Created Members");

            //Cardio Training Session
            member1.TrainingSessions.Add(new TrainingSession { SessionID = 356741891, SessionDate = new DateTime (2026, 6, 24), SessionType = "Cardio", DurationMinutes = 50, CoachNotes = "stamina improved since last week"});
            member2.TrainingSessions.Add(new TrainingSession { SessionID = 331562617, SessionDate = new DateTime (2026, 6, 24), SessionType = "Cardio", DurationMinutes = 50, CoachNotes = "stamina stayed moderate since last week"});

            //Weight Training Session
            member1.TrainingSessions.Add(new TrainingSession { SessionID = 462198317, SessionDate = new DateTime(2026, 6, 26), SessionType = "HIIT", DurationMinutes = 30, CoachNotes = "strength stayed moderate since last week" });
            member2.TrainingSessions.Add(new TrainingSession { SessionID = 489039178, SessionDate = new DateTime (2026, 6, 26), SessionType = "HIIT", DurationMinutes = 30, CoachNotes = "strength improved since last week" });

            Console.WriteLine("Added training sessions to members");
        }

    }
}
