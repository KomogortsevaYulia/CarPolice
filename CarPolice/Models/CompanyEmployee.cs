
//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CarPolice.Models
{

using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class CompanyEmployee
    {
        public CompanyEmployee()
        {
            this.results = new HashSet<results>();
        }


    public int id { get; set; }

    public string login { get; set; }

    public string password { get; set; }
        [Display(Name = "ФИО сотрудника фирмы")]
        public string full_name { get; set; }

    public int pass_no { get; set; }



    public virtual ICollection<results> results { get; set; }

}

}
