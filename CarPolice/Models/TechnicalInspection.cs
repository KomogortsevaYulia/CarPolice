
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
    public partial class TechnicalInspection
{

    public TechnicalInspection()
    {

        this.results = new HashSet<results>();

    }


    public int id { get; set; }
        [Display(Name = "Заключение ТО")]
        public int conclusion { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Дата ТО")]
        public System.DateTime Date { get; set; }



    public virtual ICollection<results> results { get; set; }

}

}
