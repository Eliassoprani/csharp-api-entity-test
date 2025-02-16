using System.ComponentModel.DataAnnotations.Schema;
using workshop.wwwapi.DTO;

namespace workshop.wwwapi.Models
{
    public class DoctorDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public DoctorDTO(Doctor doctor)
        {
            Id = doctor.Id;
            FullName = doctor.FullName;
        }

    }
}