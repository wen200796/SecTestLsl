using Microsoft.AspNetCore.Mvc.Rendering;
using SecTestLsl.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SecTestLsl.Areas.AdmMember.ViewModels
{
    public class MemberBasicViewModel
    {
        [Key]
        [Display(Name ="會員ID")]
        public int? MemberId { get; set; }
        [Required(ErrorMessage ="顯示名稱必填")]
        [StringLength(30)]
        [Display(Name = "顯示名稱")]
        public string? MemberShowName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "信箱")]
        public string? Email { get; set; }
        [Required]
        [Display(Name = "接收優惠資訊")]
        public string GetCampInfo { get; set; }
        //public List<SelectListItem>? GetCampInfoList { get; set; }
        public static List<MemberBasicViewModel> GetCollection(LifeShareLearnContext context)
        {
            var dbMemberCollection = context.tMembers;
            List<MemberBasicViewModel> memberBasicVmCollection = new List<MemberBasicViewModel>();
            foreach(tMember dbMember in dbMemberCollection)
            {
                var memberBasicVm = new MemberBasicViewModel();
                memberBasicVm.MemberId = dbMember.fMemberId;
                memberBasicVm.MemberShowName = dbMember.fShowName;
                memberBasicVm.Email = dbMember.fEmail;
                memberBasicVm.GetCampInfo = dbMember.fGetCampaignInfo == true ? "是" : "否";
                memberBasicVmCollection.Add(memberBasicVm);
            }
            return  memberBasicVmCollection;
        }
    }

}
