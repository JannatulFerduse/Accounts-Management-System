using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group_C_06_SSAC.Models;
using Group_C_06_SSAC.Data;

namespace Group_C_06_SSAC.Controllers
{
    public class HomeController : Controller
    {
        private readonly dataContext _context;
        public HomeController(dataContext context)
        {
            _context = context;
        }
        public IActionResult facreg()
        {
            return View();
        }
        public IActionResult stdlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult stdlog(salary salary)
        {
            var test = _context.salary;
            var m = new List<salary>();
            var i = _context.salary.Where(x => x.id == salary.id && x.name == salary.name).FirstOrDefault();
            if (i == null)
            {
                ViewBag.Login = "Data not exist";
            }
            else
            {
                ViewBag.Login = "Data Found";

                var s = new salary();

                s.date = i.date;
                s.monthly = i.monthly;
                s.monthly = i.monthly;
                s.rent = i.rent;
                s.bonus = i.bonus;
                s.hospital = i.hospital;
                s.recieved = i.recieved;
                
                m.Add(s);

                return View("facultydetails", m);
            }
            return View();
        }
       
        public IActionResult stdreg()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult>stdreg(Students model)
        {
            if (ModelState.IsValid)
            {
                Students lcl_student = new Students
                {
                    Id = model.Id,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Standard = model.Standard,
                    Address = model.Address,
                    Email = model.Email,
                };
                _context.student.Add(lcl_student);
                await _context.SaveChangesAsync();
                ViewBag.Success = "Data has been successfully saved";
                return View();
            }

            return View(model);
        }

        public IActionResult studentList()
        {
            /*var test = _context.Students.FirstOrDefault();

            Students model = new Students
            {
                Id = test.Id,
                Name = test.Name

            };

            return View(model);*/
            var test = _context.student;
            var model = new List<Students>();
            foreach (var i in test)
            {
                var s = new Students();
                s.Id = i.Id;
                s.Firstname = i.Firstname;
                s.Lastname = i.Lastname;
         
                model.Add(s);
            }

            return View(model);

        }
        public IActionResult facultylist()
        {
            var test = _context.Faculty;
            var mode = new List<Faculty>();
            foreach (var i in test)
            {
                var s = new Faculty();
                s.Id = i.Id;
                s.Firstname = i.Firstname;
                mode.Add(s);
            }

            return View(mode);

        }
        public IActionResult Index()

        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(payment pay)
        {
            var test = _context.Pay;
            var model = new List<payment>();
            var i = _context.Pay.Where(x => x.id == pay.id && x.name == pay.name).FirstOrDefault();
            if (i == null)
            {
                ViewBag.Login = "Data not exist";
            }
            else
            {
                ViewBag.Login = "Data Found";
                
                var s = new payment();
                
                s.date = i.date;
                s.admission = i.admission;
                s.monthly = i.monthly;
                s.xam = i.xam;
                s.tie = i.tie;
                s.syllabus = i.syllabus;
                s.sports = i.sports;
                s.picnic = i.picnic;
                model.Add(s);

                return View("studentdetails", model);
            }
            return View();
        }
        /*public IActionResult stdlog(Students std)
        {
            var test = _context.student;
            var model = new List<Students>();
            var i = _context.student.Where(x => x.Id == std.Id && x.Firstname == std.Firstname).FirstOrDefault();
            if (i == null)
            {
                ViewBag.Login = "Data not exist";
            }
            else
            {
                ViewBag.Login = "Data Found";

                var tst = _context.student;
                var m = new List<payment>();
                var j = _context.payment.FirstOrDefault();
                var s = new payment();
                s.date = j.date;
                s.money = j.money;


                m.Add(s);

                return View("studentdetails", model);
            }
            return View();
        }
        */
        public ActionResult Edit(int id)
        {
            var tableData = _context.student.ToList();
            //LINQ
            var selectList =
                from student in _context.student
                where student.Id == id
                select student;
            var a = new Students();
            a.Id = selectList.FirstOrDefault().Id;
            a.Firstname = selectList.FirstOrDefault().Firstname;
            a.Lastname = selectList.FirstOrDefault().Lastname;
            a.Standard = selectList.FirstOrDefault().Standard;
            a.Address = selectList.FirstOrDefault().Address;
            a.Email = selectList.FirstOrDefault().Email;
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(int id, Students model)
        {
            try
            {
                using (var db = _context)
                {
                    Students modelObject = new Students
                    {
                        Id = model.Id,
                        Firstname = model.Firstname,
                        Lastname = model.Lastname,
                        Standard = model.Standard,
                        Address = model.Address,
                        Email = model.Email
                    };
                    db.student.Update(modelObject);
                    db.SaveChanges();
                }

                return RedirectToAction(nameof(studentList));
            }
            catch (Exception e)
            {
                //Exception Handling
                ViewData["Message"] = e.Message;
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            var tableData = _context.student.ToList();
            //LINQ
            var selectList =
                from student in _context.student
                where student.Id == id
                select student;
            var a = new Students();
            a.Id = selectList.FirstOrDefault().Id;
            a.Firstname = selectList.FirstOrDefault().Firstname;
            a.Lastname = selectList.FirstOrDefault().Lastname;
            a.Standard = selectList.FirstOrDefault().Standard;
            a.Address = selectList.FirstOrDefault().Address;
            a.Email = selectList.FirstOrDefault().Email;
            
            return View(a);
        }

        // POST: Product/Delete/5
        [HttpPost]
       
        public ActionResult Delete(int id, Students model)
        {
            try
            {
                using (var db = _context)
                {

                    Students modelObject = new Students
                    {
                        Id = model.Id,
                        Firstname = model.Firstname,
                        Lastname = model.Lastname,
                        Standard = model.Standard,
                        Address = model.Address,
                        Email = model.Email
                    };
                    db.student.Remove(modelObject);
                    db.SaveChanges();
                }


                return RedirectToAction(nameof(studentList));
            }
            catch
            {
                return View();
            }
        }
    
    public ActionResult Details(int id)
        {
            var tableData = _context.student.ToList();
            //LINQ
            var selectList =
                from student in _context.student
                where student.Id == id
                select student;
            //User of View Model
         
            var vmObject = new Students();
            vmObject.Firstname = selectList.FirstOrDefault().Firstname;
            vmObject.Lastname = selectList.FirstOrDefault().Lastname;
            vmObject.Standard = selectList.FirstOrDefault().Standard;
            vmObject.Address = selectList.FirstOrDefault().Address;
            vmObject.Email = selectList.FirstOrDefault().Email;
            
            return View(vmObject);
        }







        public ActionResult EditF(int id)
        {
            var tableData = _context.Faculty.ToList();
            //LINQ
            var selectList =
                from Faculty in _context.Faculty
                where Faculty.Id == id
                select Faculty;
            var a = new Faculty();
            a.Id = selectList.FirstOrDefault().Id;
            a.Firstname = selectList.FirstOrDefault().Firstname;
            a.Lastname = selectList.FirstOrDefault().Lastname;
            a.Designation = selectList.FirstOrDefault().Designation;
            a.Address = selectList.FirstOrDefault().Address;
            a.Email = selectList.FirstOrDefault().Email;
            a.salary = selectList.FirstOrDefault().salary;
            a.date = selectList.FirstOrDefault().date;
            return View(a);
        }
        [HttpPost]
        public ActionResult EditF(int id, Faculty mode)
        {
            try
            {
                using (var db = _context)
                {
                    Faculty modeObject = new Faculty
                    {
                        Id = mode.Id,
                        Firstname = mode.Firstname,
                        Lastname = mode.Lastname,
                        Designation = mode.Designation,
                        Address = mode.Address,
                        Email = mode.Email,
                        salary = mode.salary,
                        date = mode.date,
                    };
                    db.Faculty.Update(modeObject);
                    db.SaveChanges();
                }

                return RedirectToAction(nameof(facultylist));
            }
            catch (Exception e)
            {
                //Exception Handling
                ViewData["Message"] = e.Message;
                return View();
            }
        }
        public ActionResult DeleteF(int id)
        {
            var tableData = _context.Faculty.ToList();
            //LINQ
            var selectList =
                from Faculty in _context.Faculty
                where Faculty.Id == id
                select Faculty;
            var a = new Faculty();
            a.Id = selectList.FirstOrDefault().Id;
            a.Firstname = selectList.FirstOrDefault().Firstname;
            a.Lastname = selectList.FirstOrDefault().Lastname;
            a.Designation = selectList.FirstOrDefault().Designation;
            a.Address = selectList.FirstOrDefault().Address;
            a.Email = selectList.FirstOrDefault().Email;
            a.salary = selectList.FirstOrDefault().salary;
            a.date = selectList.FirstOrDefault().date;

            return View(a);
        }

        // POST: Product/Delete/5
        [HttpPost]

        public ActionResult DeleteF(int id, Faculty mode)
        {
            try
            {
                using (var db = _context)
                {

                    Faculty modeObject = new Faculty
                    {
                        Id = mode.Id,
                        Firstname = mode.Firstname,
                        Lastname = mode.Lastname,
                        Designation = mode.Designation,
                        Address = mode.Address,
                        Email = mode.Email,
                        salary = mode.salary,
                        date = mode.date,
                    };
                    db.Faculty.Remove(modeObject);
                    db.SaveChanges();
                }


                return RedirectToAction(nameof(facultylist));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DetailsF(int id)
        {
            var tableData = _context.Faculty.ToList();
            //LINQ
            var selectList =
                from Faculty in _context.Faculty
                where Faculty.Id == id
                select Faculty;
            //User of View Model

            var vmObject = new Faculty();
            vmObject.Id = selectList.FirstOrDefault().Id;
            vmObject.Firstname = selectList.FirstOrDefault().Firstname;
            vmObject.Lastname = selectList.FirstOrDefault().Lastname;
            vmObject.Designation = selectList.FirstOrDefault().Designation;
            vmObject.Address = selectList.FirstOrDefault().Address;
            vmObject.Email = selectList.FirstOrDefault().Email;
            vmObject.salary = selectList.FirstOrDefault().salary;
            vmObject.date = selectList.FirstOrDefault().date;

            return View(vmObject);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        
        public IActionResult payment()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> payment(payment model)
        {
            if (ModelState.IsValid)
            {
                payment lcl_payment = new payment
                {
                    id = model.id,
                    name = model.name,
                    date = model.date,
                    admission = model.admission,
                    monthly = model.monthly,
                    xam = model.xam,
                    tie = model.tie,
                    syllabus = model.syllabus,
                    sports = model.sports,
                    picnic = model.picnic,
                };
                _context.Pay.Add(lcl_payment);
                await _context.SaveChangesAsync();
                ViewBag.Success = "Data has been successfully saved";
                return View();
            }

            return View(model);
        }


        public IActionResult salary()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> salary(salary model)
        {
            if (ModelState.IsValid)
            {
                salary lcl_salary = new salary
                {
                    id = model.id,
                    name = model.name,
                    date = model.date,
                    monthly = model.monthly,
                    
                    rent = model.rent,
                    bonus = model.bonus,
                    hospital = model.hospital,
                    recieved = model.recieved,
                };
                _context.salary.Add(lcl_salary);
                await _context.SaveChangesAsync();
                ViewBag.Success = "Data has been successfully saved";
                return View();
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
