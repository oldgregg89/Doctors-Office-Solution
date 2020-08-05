using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DoctorsOffice.Controllers
{
  public class PatientsController : Controller
  {
    private readonly DoctorsOfficeContext _db;
    public PatientsController(DoctorsOfficeContext db)
    {
      _db = db;
    }
    public ActionResult Details(int id)
    {
      var thisPatient = _db.Patients
          .Include(patient => patient.Doctors)
          .ThenInclude(join => join.Doctor)
          .FirstOrDefault(patient => patient.PatientId == id);
      return View(thisPatient);
    }
    public ActionResult Create()
    {
    ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
    return View();
    }
    public ActionResult Edit(int id)
    {
    var thisPatient = _db.Patients.FirstOrDefault(patients => patients.PatientId == id);
    ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
    return View(thisPatient);
    }

    [HttpPost]
    public ActionResult Edit(Patient patient, int DoctorId)
    {
      if (DoctorId != 0)
      {
        _db.DoctorPatient.Add(new DoctorPatient() { DoctorId = DoctorId, PatientId = patient.PatientId });
      }
      _db.Entry(patient).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult AddDoctor(int id)
    {
    var thisPatient = _db.Patients.FirstOrDefault(patients => patients.PatientId == id);
    ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
    return View(thisPatient);
    }
    [HttpPost]
    public ActionResult AddDoctor(Patient patient, int DoctorId)
    {
      if (DoctorId != 0)
      {
      _db.DoctorPatient.Add(new DoctorPatient() { CourseId = CourseId, StudentId = student.StudentId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      return View(thisStudent);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      _db.Students.Remove(thisStudent);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult DeleteCourse(int joinId)
    {
      var joinEntry = _db.CourseStudent.FirstOrDefault(entry => entry.CourseStudentId == joinId);
      _db.CourseStudent.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult Create(Student student, int CourseId)
    {
      _db.Students.Add(student);
    if (CourseId != 0)
    {
        _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId });
    }
    _db.SaveChanges();
    return RedirectToAction("Index");
    }
    public ActionResult Index()
    {
      List<Student> model = _db.Students.ToList();
      return View(model);
    }
  }
}