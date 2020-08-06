using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DoctorsOffice.Models
{
  public class Patient
  {
    public Patient()
    {
      this.Doctors = new HashSet<DoctorPatient>();
    }
    public int PatientId { get; set; }
    public string Name  { get; set; }
    public string Affliction  { get; set; }
    public ICollection<DoctorPatient> Doctors { get; }
  }
}