﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name="Ad Soyad")]
        [Required(ErrorMessage="Lütfen ad soyad giriniz")]
        public string nameSurname { get; set; }

        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Display(Name ="Şifre Tekrar")]
        [Required(ErrorMessage ="Şİfreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name ="Mail Adresi")]
        [Required(ErrorMessage ="Lütfen mail adresinizi giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }



    }
}
