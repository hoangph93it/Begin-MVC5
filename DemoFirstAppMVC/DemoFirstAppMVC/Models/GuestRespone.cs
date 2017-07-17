using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DemoFirstAppMVC.Models
{
    public class GuestRespone
    {
        [Required(ErrorMessage = "Bạn phải nhập vào họ tên nhé!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập vào Email nhé!")]
        [EmailAddress(ErrorMessage ="Bạn phải nhập vào đúng dạng email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập vào số phone nhé!")]
        [Phone(ErrorMessage ="Bạn phải nhập đúng dạng số điện thoại!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Bạn hãy lựa chọn có tới tham dự hay không nhé!")]
        public bool? WillAtend { get; set; }
    }
}