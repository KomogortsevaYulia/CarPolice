
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
    public partial class Officer
{

    public Officer()
    {

        this.results = new HashSet<results>();

    }


    public int id { get; set; }

    public string login { get; set; }


         public string password { get; set; }

        [Display(Name = "ФИО сотрудника ГАИ")]
        public string full_name { get; set; }

        
        public string rank { get; set; }

        
        public string position { get; set; }



    public virtual ICollection<results> results { get; set; }

}

}
