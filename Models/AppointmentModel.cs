using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppointmentWebApp.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Patient's worth")]
        public decimal PatientNetWorth { get; set; }
        [DisplayName("Doctor's last name")]
        public string DoctorName { get; set; }
        [Range(1, 10)]
        [DisplayName("Patient's pain level")]
        public int PainLevel { get; set; }

        public AppointmentModel()
        {

        }
    }
}
