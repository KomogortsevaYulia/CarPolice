﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;


public partial class TRPKEntities : DbContext
{
    public TRPKEntities()
        : base("name=TRPKEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Car> Car { get; set; }

    public DbSet<CarOwner> CarOwner { get; set; }

    public DbSet<CompanyEmployee> CompanyEmployee { get; set; }

    public DbSet<Officer> Officer { get; set; }

    public DbSet<results> results { get; set; }

    public DbSet<TechnicalInspection> TechnicalInspection { get; set; }


    public virtual int deleteCar(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCar", idParameter);
    }


    public virtual int deleteCarOwner(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCarOwner", idParameter);
    }


    public virtual int deleteCompanyEmployee(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCompanyEmployee", idParameter);
    }


    public virtual int deleteOfficer(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteOfficer", idParameter);
    }


    public virtual int deleteresults(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteresults", idParameter);
    }


    public virtual int deleteTechnicalInspection(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteTechnicalInspection", idParameter);
    }


    public virtual int incertCar(Nullable<int> id, string body_no, string license_plate, string mark, string color, string engine_no, Nullable<int> pass_no)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        var body_noParameter = body_no != null ?
            new ObjectParameter("body_no", body_no) :
            new ObjectParameter("body_no", typeof(string));


        var license_plateParameter = license_plate != null ?
            new ObjectParameter("license_plate", license_plate) :
            new ObjectParameter("license_plate", typeof(string));


        var markParameter = mark != null ?
            new ObjectParameter("mark", mark) :
            new ObjectParameter("mark", typeof(string));


        var colorParameter = color != null ?
            new ObjectParameter("color", color) :
            new ObjectParameter("color", typeof(string));


        var engine_noParameter = engine_no != null ?
            new ObjectParameter("engine_no", engine_no) :
            new ObjectParameter("engine_no", typeof(string));


        var pass_noParameter = pass_no.HasValue ?
            new ObjectParameter("pass_no", pass_no) :
            new ObjectParameter("pass_no", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("incertCar", idParameter, body_noParameter, license_plateParameter, markParameter, colorParameter, engine_noParameter, pass_noParameter);
    }


    public virtual int incertCarOwner(Nullable<int> id, string full_name, string address, string gender, Nullable<int> driver_license_no, Nullable<System.DateTime> dOB)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        var full_nameParameter = full_name != null ?
            new ObjectParameter("full_name", full_name) :
            new ObjectParameter("full_name", typeof(string));


        var addressParameter = address != null ?
            new ObjectParameter("address", address) :
            new ObjectParameter("address", typeof(string));


        var genderParameter = gender != null ?
            new ObjectParameter("gender", gender) :
            new ObjectParameter("gender", typeof(string));


        var driver_license_noParameter = driver_license_no.HasValue ?
            new ObjectParameter("driver_license_no", driver_license_no) :
            new ObjectParameter("driver_license_no", typeof(int));


        var dOBParameter = dOB.HasValue ?
            new ObjectParameter("DOB", dOB) :
            new ObjectParameter("DOB", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("incertCarOwner", idParameter, full_nameParameter, addressParameter, genderParameter, driver_license_noParameter, dOBParameter);
    }


    public virtual int incertCompanyEmployee(Nullable<int> id, string login, string password, string full_name, Nullable<int> pass_no)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        var loginParameter = login != null ?
            new ObjectParameter("login", login) :
            new ObjectParameter("login", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var full_nameParameter = full_name != null ?
            new ObjectParameter("full_name", full_name) :
            new ObjectParameter("full_name", typeof(string));


        var pass_noParameter = pass_no.HasValue ?
            new ObjectParameter("pass_no", pass_no) :
            new ObjectParameter("pass_no", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("incertCompanyEmployee", idParameter, loginParameter, passwordParameter, full_nameParameter, pass_noParameter);
    }


    public virtual int incertOfficer(Nullable<int> id, string login, string password, string full_name, string rank, string position)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        var loginParameter = login != null ?
            new ObjectParameter("login", login) :
            new ObjectParameter("login", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var full_nameParameter = full_name != null ?
            new ObjectParameter("full_name", full_name) :
            new ObjectParameter("full_name", typeof(string));


        var rankParameter = rank != null ?
            new ObjectParameter("rank", rank) :
            new ObjectParameter("rank", typeof(string));


        var positionParameter = position != null ?
            new ObjectParameter("position", position) :
            new ObjectParameter("position", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("incertOfficer", idParameter, loginParameter, passwordParameter, full_nameParameter, rankParameter, positionParameter);
    }


    public virtual int incertresults(Nullable<int> id, Nullable<int> id_car, Nullable<int> id_officer, Nullable<int> id_employee, Nullable<int> id_owner, Nullable<int> id_inspection)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        var id_carParameter = id_car.HasValue ?
            new ObjectParameter("id_car", id_car) :
            new ObjectParameter("id_car", typeof(int));


        var id_officerParameter = id_officer.HasValue ?
            new ObjectParameter("id_officer", id_officer) :
            new ObjectParameter("id_officer", typeof(int));


        var id_employeeParameter = id_employee.HasValue ?
            new ObjectParameter("id_employee", id_employee) :
            new ObjectParameter("id_employee", typeof(int));


        var id_ownerParameter = id_owner.HasValue ?
            new ObjectParameter("id_owner", id_owner) :
            new ObjectParameter("id_owner", typeof(int));


        var id_inspectionParameter = id_inspection.HasValue ?
            new ObjectParameter("id_inspection", id_inspection) :
            new ObjectParameter("id_inspection", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("incertresults", idParameter, id_carParameter, id_officerParameter, id_employeeParameter, id_ownerParameter, id_inspectionParameter);
    }


    public virtual int incertTechnicalInspection(Nullable<int> id, Nullable<int> conclusion, Nullable<System.DateTime> date)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        var conclusionParameter = conclusion.HasValue ?
            new ObjectParameter("conclusion", conclusion) :
            new ObjectParameter("conclusion", typeof(int));


        var dateParameter = date.HasValue ?
            new ObjectParameter("Date", date) :
            new ObjectParameter("Date", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("incertTechnicalInspection", idParameter, conclusionParameter, dateParameter);
    }

}

}

