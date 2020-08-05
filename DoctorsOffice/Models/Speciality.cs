using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Systems;

namespace DoctorsOffice.Models
{
  public class Speciality
  {
    public Speciality()
    {
      this.Doctors = new HashSet<DoctorSpeciality>();
    }
    public int SpecialityId { get; set; }
    public string Type  { get; set; }
    public ICollection<DoctorSpeciality> Doctors { get; }
  }
}