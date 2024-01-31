using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecTestLsl.Models;
using SecTestLsl.Areas.AdmMember.ViewModels;
namespace SecTestLsl.Areas.AdmMember.Controllers
{
    [Area("AdmMember")]
    public class MemberBasicController : Controller
    {
        private readonly LifeShareLearnContext _context;

        public MemberBasicController(LifeShareLearnContext context)
        {
            _context = context;
        }

        // GET: AdmMember/MemberBasic
        public IActionResult Index()
        {
           IEnumerable<MemberBasicViewModel> mbVMCOllection = MemberBasicViewModel.GetCollection(_context);
            return View(mbVMCOllection);
        }

        // GET: AdmMember/MemberBasic/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    //if (id == null || _context.MemberBasicViewModel == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //var memberBasicViewModel = await _context.MemberBasicViewModel
        //    //    .FirstOrDefaultAsync(m => m.MemberId == id);
        //    //if (memberBasicViewModel == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    return View(memberBasicViewModel);
        //}

        // GET: AdmMember/MemberBasic/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdmMember/MemberBasic/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("MemberId,MemberShowName,Email,GetCampInfo")] MemberBasicViewModel memberBasicViewModel)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(memberBasicViewModel);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Content("這段如果有放_ValidationScriptsPartial 就不易被觸發");
        }

        //// GET: AdmMember/MemberBasic/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.tMember == null)
        //    {
        //        return NotFound();
        //    }

        //    var dbMember = await _context.tMember.FindAsync(id);
        //    if (dbMember == null)
        //    {
        //        return NotFound();
        //    }
        //    var memberBVm = new MemberBasicViewModel { MemberId = id };
        //    memberBVm.MemberShowName = dbMember.fShowName;
        //    memberBVm.Email = dbMember.fEmail;
        //    return PartialView("~/Areas/AdmMember/Views/MemberBasic/_EditMemberPartial.cshtml", memberBVm);
        //}

        // POST: AdmMember/MemberBasic/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("MemberShowName,Email,GetCampInfo")] MemberBasicViewModel memberBasicViewModel)
        {
            //if (id != memberBasicViewModel.MemberId)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(memberBasicViewModel);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!MemberBasicViewModelExists(memberBasicViewModel.MemberId))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }
            return Content("這段如果有放_ValidationScriptsPartial 就不易被觸發");
        }

        // GET: AdmMember/MemberBasic/Delete/5
        //        public async Task<IActionResult> Delete(int? id)
        //        {
        //            //if (id == null || _context.MemberBasicViewModel == null)
        //            //{
        //            //    return NotFound();
        //            //}

        //            //var memberBasicViewModel = await _context.MemberBasicViewModel
        //            //    .FirstOrDefaultAsync(m => m.MemberId == id);
        //            //if (memberBasicViewModel == null)
        //            //{
        //            //    return NotFound();
        //            //}

        //            //return View(memberBasicViewModel);
        //        }

        //        // POST: AdmMember/MemberBasic/Delete/5
        //        [HttpPost, ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> DeleteConfirmed(int? id)
        //        {
        //            //if (_context.MemberBasicViewModel == null)
        //            //{
        //            //    return Problem("Entity set 'LifeShareLearnContext.MemberBasicViewModel'  is null.");
        //            //}
        //            //var memberBasicViewModel = await _context.MemberBasicViewModel.FindAsync(id);
        //            //if (memberBasicViewModel != null)
        //            //{
        //            //    _context.MemberBasicViewModel.Remove(memberBasicViewModel);
        //            //}

        //            //await _context.SaveChangesAsync();
        //            //return RedirectToAction(nameof(Index));
        //        }

        //        //private bool MemberBasicViewModelExists(int? id)
        //        //{
        //        //  return (_context.MemberBasicViewModel?.Any(e => e.MemberId == id)).GetValueOrDefault();
        //        //}
    }
}
