using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CCSolutionHRM.Models;

namespace CCSolutionHRM.DAL
{
    public class CCSolutionInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CCSolutionContext>
    {
        protected override void Seed(CCSolutionContext context)
        {
            #region Qualification
            var qualification = new List<Qualification>
            {
                new Qualification{Name="SSC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Qualification{Name="HSC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Qualification{Name="Graduation",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Qualification{Name="Masters",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Qualification{Name="PHD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Qualification{Name="MPhil",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Qualification{Name="Doctorate",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Qualification{Name="Other",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            qualification.ForEach(s => context.Qualifications.Add(s));
            context.SaveChanges();
            #endregion

            #region Relation
            var relation = new List<Relation>
            {
                new Relation{Name="Grand Father",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Grand Mother",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Father",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Mother",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Brother",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Sister",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Spouse",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Son",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Daughter",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Grand Son",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Grand Daughter",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Uncle",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Aunty",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Cousin",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Relation{Name="Friend",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            relation.ForEach(s => context.Relations.Add(s));
            context.SaveChanges();
            #endregion

            #region MaritalStatus
            var maritalStatus = new List<MaritalStatus>
            {
                new MaritalStatus{Name="Married",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new MaritalStatus{Name="Un Married",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new MaritalStatus{Name="Seprated",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            maritalStatus.ForEach(s => context.MaritalStatuss.Add(s));
            context.SaveChanges();
            #endregion

            #region Religion
            var religion = new List<Religion>
            {
                new Religion{Name="Christianity",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Religion{Name="Islam",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Religion{Name="Nonreligious",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Religion{Name="Hinduism",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Religion{Name="Buddhism",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Religion{Name="Sikhism",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Religion{Name="Others",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            religion.ForEach(s => context.Religions.Add(s));
            context.SaveChanges();
            #endregion

            #region Company
            var company = new List<Company>
            {
                new Company{Address="",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",DialingCode=971,EmailAddress="",Name="CCSolution",PhoneNumber="",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1",Url="",Deleted=false}
            };
            company.ForEach(s => context.Companys.Add(s));
            context.SaveChanges();

            var attribute = new List<Models.Attribute>
            {
                new Models.Attribute{Name="Create",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Models.Attribute{Name="Delete",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Models.Attribute{Name="Details",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Models.Attribute{Name="Edit",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Models.Attribute{Name="List",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            attribute.ForEach(s => context.Attributes.Add(s));
            context.SaveChanges();
            #endregion

            #region RoleType
            var roletype = new List<RoleType>
            {
                new RoleType{Name="Super Admin",IgnoreCompany=true,IgnoreMenu=true,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleType{Name="Client Admin",IgnoreCompany=false,IgnoreMenu=true,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleType{Name="Client User",IgnoreCompany=false,IgnoreMenu=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            roletype.ForEach(s => context.RoleTypes.Add(s));
            context.SaveChanges();
            #endregion

            #region Role
            var role = new List<Role>
            {
                new Role{Name="Super Admin",RoleTypeId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Role{Name="Admin",RoleTypeId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Role{Name="User",RoleTypeId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            role.ForEach(s => context.Roles.Add(s));
            context.SaveChanges();
            #endregion

            #region RoleAttribute
            var roleattribute = new List<RoleAttribute>
            {
                //Super Admin Attribute
                new RoleAttribute{AttributeId=1,RoleId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=2,RoleId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=3,RoleId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=4,RoleId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=5,RoleId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},

                //Admin Attribute
                new RoleAttribute{AttributeId=1,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=2,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=3,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=4,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=5,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                
                //User Attribute
                new RoleAttribute{AttributeId=3,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=4,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleAttribute{AttributeId=5,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            roleattribute.ForEach(s => context.RoleAttributes.Add(s));
            context.SaveChanges();
            #endregion

            #region Users
            var user = new List<Users>
            {
                new Users{CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,LoginId="rizwanahmad",Name="Muhammad Rizwan",Password="Axact123",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Users{CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,LoginId="sabir",Name="Muhammad Sabir",Password="Axact123",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Users{CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,LoginId="aisha",Name="Aisha",Password="Axact123",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            user.ForEach(s => context.Userss.Add(s));
            context.SaveChanges();
            #endregion

            #region RoleUsers
            var roleuser = new List<RoleUsers>
            {
                //Super Admin Attribute
                new RoleUsers{UserId=1,RoleId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleUsers{UserId=2,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleUsers{UserId=3,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            roleattribute.ForEach(s => context.RoleAttributes.Add(s));
            context.SaveChanges();
            #endregion

            #region RoleCompany
            var rolecompany = new List<RoleCompany>
            {
                new RoleCompany{CompanyId=1,RoleId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleCompany{CompanyId=1,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleCompany{CompanyId=1,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
            };
            rolecompany.ForEach(s => context.RoleCompanys.Add(s));
            context.SaveChanges();
            #endregion

            #region Menu
            var menu = new List<Menu>
            {
                new Menu{MenuClass="",Name="Home",Action="",ParentId=0,Sequence=1,Url="#",Viewable=true,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                //Employee
                new Menu{MenuClass="",Name="All Employees",Action="Index",ParentId=0,Sequence=1,Url="#",Viewable=true,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Add Employee",Action="Create",ParentId=1,Sequence=2,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="View Employee",Action="Details",ParentId=1,Sequence=3,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Delete Employee",Action="Delete",ParentId=1,Sequence=4,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Update Employees",Action="Edit",ParentId=1,Sequence=5,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                
                //Departments
                new Menu{MenuClass="",Name="All Departments",Action="Index",ParentId=0,Sequence=6,Url="#",Viewable=true,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Add Departments",Action="Create",ParentId=6,Sequence=7,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="View Departments",Action="Details",ParentId=6,Sequence=8,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Delete Departments",Action="Delete",ParentId=6,Sequence=9,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Update Departments",Action="Edit",ParentId=6,Sequence=10,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},

                //Projects
                new Menu{MenuClass="",Name="All Project",Action="Index",ParentId=0,Sequence=11,Url="#",Viewable=true,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Add Project",Action="Create",ParentId=11,Sequence=12,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="View Project",Action="Details",ParentId=12,Sequence=13,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Delete Project",Action="Delete",ParentId=13,Sequence=14,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Update Project",Action="Edit",ParentId=14,Sequence=15,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},

                //Projects
                new Menu{MenuClass="",Name="All Company",Action="Index",ParentId=0,Sequence=16,Url="#",Viewable=true,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Add Company",Action="Create",ParentId=15,Sequence=17,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="View Company",Action="Details",ParentId=15,Sequence=18,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Delete Company",Action="Delete",ParentId=15,Sequence=19,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Menu{MenuClass="",Name="Update Company",Action="Edit",ParentId=15,Sequence=20,Url="#",Viewable=false,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}

            };
            menu.ForEach(s => context.Menus.Add(s));
            context.SaveChanges();
            #endregion

            #region RoleMenu
            var rolemenu = new List<RoleMenu>
            {
                new RoleMenu{MenuId=1,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=2,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=3,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=4,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=5,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=6,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=7,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=8,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=9,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=10,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=11,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=12,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=13,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=14,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=15,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=16,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=17,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=18,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=19,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=20,RoleId=3,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},

                new RoleMenu{MenuId=1,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=2,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=3,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=4,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=5,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=6,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=7,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=8,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=9,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=10,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=11,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=12,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=13,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=14,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=15,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=16,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=17,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=18,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=19,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new RoleMenu{MenuId=20,RoleId=2,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}
                
                //Employee
                 
            };
            rolemenu.ForEach(s => context.RoleMenus.Add(s));
            context.SaveChanges();
            #endregion

            #region Department
            var departments = new List<Department>
            {
                new Department{Name="Administration",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Department{Name="Human Resource",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Department{Name="Sales",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Department{Name="Training & Development",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Department{Name="Safety & Security",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},                
                new Department{Name="Procurement",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Department{Name="Compensation and Benefits",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Department{Name="Public Relations",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}

            };

            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();
            #endregion

            #region Project
            var projects = new List<Project>
            {
                new Project{Name="Project 1",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 2",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 3",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 4",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 5",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 6",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 7",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 8",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 9",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Project{Name="Project 10",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}

            };

            projects.ForEach(s => context.Projects.Add(s));
            context.SaveChanges();
            #endregion

            #region Designation
            var designation = new List<Designation>
            {
                new Designation{Name="President",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Vice President",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Associate Vice President",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Assistant Vice President",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Senior Manager",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Manager",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Associate Manager",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Assistant Manager",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Senior Executive",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Associate Executive",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Executive",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Clerk",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new Designation{Name="Peon",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}

            };

            designation.ForEach(s => context.Designations.Add(s));
            context.SaveChanges();
            #endregion

            #region EmployementStatus
            var employementStatus = new List<EmployementStatus>
            {
                new EmployementStatus{Name="OnService",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new EmployementStatus{Name="Retired",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new EmployementStatus{Name="Suspended",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new EmployementStatus{Name="Terminated",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}

            };

            employementStatus.ForEach(s => context.EmployementStatuss.Add(s));
            context.SaveChanges();
            #endregion

            #region EmployementType
            var employementType = new List<EmployementType>
            {
                new EmployementType{Name="Temporary",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new EmployementType{Name="Permenant",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new EmployementType{Name="Contract",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}

            };

            employementStatus.ForEach(s => context.EmployementStatuss.Add(s));
            context.SaveChanges();
            #endregion

            #region WorkSite
            var workSite = new List<WorkSite>
            {
                new WorkSite{Name="Dubai",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new WorkSite{Name="Abu Dhabi",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new WorkSite{Name="Al Ain",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new WorkSite{Name="Sharjah",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new WorkSite{Name="Ras Al Khaimah",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new WorkSite{Name="Fujairah",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new WorkSite{Name="Ajman",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"},
                new WorkSite{Name="Umm Al Quwain",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1"}

            };

            workSite.ForEach(s => context.WorkSites.Add(s));
            context.SaveChanges();
            #endregion

            #region Gender
            var gender = new List<Gender>
            {
                new Gender{CreationBy=1, CreationDate = DateTime.Now, CreationIP="127.0.0.1",Delete=false,Name="Male",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP="127.0.0.1"},
                new Gender{CreationBy=1, CreationDate = DateTime.Now, CreationIP="127.0.0.1",Delete=false,Name="Female",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP="127.0.0.1"}
            };

            gender.ForEach(s => context.Genders.Add(s));
            context.SaveChanges();
            #endregion

            #region Employee
            var employee = new List<Employee>
            {
                new Employee{CompanyId=1,DateOfBirth=DateTime.Now.AddYears(-35),DepartmentId=1,DesignationId=1,EmploymentStatusId=1,EmploymentTypeId=1,GenderId=1,HireDate=DateTime.Now.AddYears(-1),
                    NationalityId=1,Title="Mr.",Name="Muhammad Rizwan",WorkSiteId=1,CreationBy = 1, CreationDate = DateTime.Now, CreationIP = "127.0.0.1", Delete = false, UpdationBy = 1, UpdationDate = DateTime.Now
                    , UpdationIP = "127.0.0.1" },

                new Employee{CompanyId=1,DateOfBirth=DateTime.Now.AddYears(-35),DepartmentId=1,DesignationId=1,EmploymentStatusId=1,EmploymentTypeId=1,GenderId=1,HireDate=DateTime.Now.AddYears(-1),
                    NationalityId=1,Title="Mr.",Name="Muhammad Sabir",WorkSiteId=1,CreationBy = 1, CreationDate = DateTime.Now, CreationIP = "127.0.0.1", Delete = false, UpdationBy = 1, UpdationDate = DateTime.Now
                    , UpdationIP = "127.0.0.1" },

                new Employee{CompanyId=1,DateOfBirth=DateTime.Now.AddYears(-35),DepartmentId=1,DesignationId=1,EmploymentStatusId=1,EmploymentTypeId=1,GenderId=1,HireDate=DateTime.Now.AddYears(-1),
                    NationalityId=1,Title="Mr.",Name="Aisha",WorkSiteId=1,CreationBy = 1, CreationDate = DateTime.Now, CreationIP = "127.0.0.1", Delete = false, UpdationBy = 1, UpdationDate = DateTime.Now
                    , UpdationIP = "127.0.0.1" },

                new Employee{CompanyId=1,DateOfBirth=DateTime.Now.AddYears(-35),DepartmentId=1,DesignationId=1,EmploymentStatusId=1,EmploymentTypeId=1,GenderId=1,HireDate=DateTime.Now.AddYears(-1),
                    NationalityId=1,Title="Mr.",Name="Hina Ali",WorkSiteId=1,CreationBy = 1, CreationDate = DateTime.Now, CreationIP = "127.0.0.1", Delete = false, UpdationBy = 1, UpdationDate = DateTime.Now
                    , UpdationIP = "127.0.0.1" },

                new Employee{CompanyId=1,DateOfBirth=DateTime.Now.AddYears(-35),DepartmentId=1,DesignationId=1,EmploymentStatusId=1,EmploymentTypeId=1,GenderId=1,HireDate=DateTime.Now.AddYears(-1),
                    NationalityId=1,Title="Mr.",Name="Yousuf Ali",WorkSiteId=1,CreationBy = 1, CreationDate = DateTime.Now, CreationIP = "127.0.0.1", Delete = false, UpdationBy = 1, UpdationDate = DateTime.Now
                    , UpdationIP = "127.0.0.1" }
            };

            employee.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
            #endregion

            #region Nationality
            var nationality = new List<Nationality>
            {
                new Nationality { CountryCode="AB",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=840,Name="Abkhazia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=93,Name="Afghanistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=355,Name="Albania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Dz",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=213,Name="Algeria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1684,Name="American Samoa",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=376,Name="Andorra",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=244,Name="Angola",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1264,Name="Anguilla",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AQ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=672,Name="Antarctica",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ag",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1268,Name="Antigua And Barbuda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="ab",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1268,Name="Antigua And Barbuda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=54,Name="Argentina",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=374,Name="Armenia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AW",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=297,Name="Aruba",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=61,Name="Australia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=43,Name="Austria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=994,Name="Azerbaijan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1242,Name="Bahamas",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=973,Name="Bahrain",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=880,Name="Bangladesh",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BB",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1246,Name="Barbados",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=375,Name="Belarus",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=32,Name="Belgium",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=501,Name="Belize",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Bj",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=229,Name="Benin",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Bm",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1441,Name="Bermuda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=975,Name="Bhutan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=591,Name="Bolivia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=387,Name="Bosnia And Herzegovina",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Bw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=267,Name="Botswana",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=55,Name="Brazil",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=673,Name="Brunei",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=359,Name="Bulgaria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Bf",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=266,Name="Burkina Faso",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=95,Name="Burma (Myanmar)",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=257,Name="Burundi",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=855,Name="Cambodia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=237,Name="Cameroon",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1,Name="Canada",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Cv",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=238,Name="Cape Verde",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ky",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1345,Name="Cayman Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=236,Name="Central African Republic",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=235,Name="Chad",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=56,Name="Chile",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=86,Name="China",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=57,Name="Colombia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=269,Name="Comoros",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ck",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=682,Name="Cook Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=506,Name="Costa Rica",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="HR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=385,Name="Croatia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=53,Name="Cuba",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=357,Name="Cyprus",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=420,Name="Czech Republic",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=243,Name="Democratic Republic Of The Congo",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="DK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=45,Name="Denmark",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Dj",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=253,Name="Djibouti",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="DM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1767,Name="Dominica",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Dr",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1809,Name="Dominican Republic",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="DR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1809,Name="Dominican Republic Ii",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Do",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1849,Name="Dominican Republic Iii",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="EC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=593,Name="Ecuador",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Eg",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=20,Name="Egypt",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SV",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=503,Name="El Salvador",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Er",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=291,Name="Enitrea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GQ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=240,Name="Equatorial Guinea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="EE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=372,Name="Estonia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Et",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=251,Name="Ethiopia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Fk",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=500,Name="Falkland Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="FO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=298,Name="Faroe Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="FJ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=679,Name="Fiji",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="FI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=358,Name="Finland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="FR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=33,Name="France",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=594,Name="French Guiana",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=689,Name="French Polynesia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=241,Name="Gabon",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Gm",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=220,Name="Gambia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=995,Name="Georgia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="DE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=49,Name="Germany",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Gh",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=233,Name="Ghana",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=350,Name="Gibraltar",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=30,Name="Greece",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Gl",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=299,Name="Greenland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1473,Name="Grenada",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Gu",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1671,Name="Guam",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=502,Name="Guatemala",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Gn",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=224,Name="Guinea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Gw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=245,Name="Guinea Bissau",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=592,Name="Guyana",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="HT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=509,Name="Haiti",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="HN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=504,Name="Honduras",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="HK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=852,Name="Hong Kong",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="HU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=36,Name="Hungary",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="IS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=354,Name="Iceland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="IN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=91,Name="India",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="ID",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=62,Name="Indonesia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="XA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=999,Name="Invalid Country Xa",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="IR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=98,Name="Iran",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="IQ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=964,Name="Iraq",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="IE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=353,Name="Ireland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="IL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=972,Name="Israel",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="IT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=39,Name="Italy",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ci",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=225,Name="Ivory Coast",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="JM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1876,Name="Jamaica",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="JP",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=81,Name="Japan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="JO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=962,Name="Jordan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=7,Name="Kazakhstan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=254,Name="Kenya",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ki",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=686,Name="Kiribati",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KW",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=965,Name="Kuwait",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=996,Name="Kyrgyzstan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="LA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=856,Name="Laos",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="LV",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=371,Name="Latvia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="LB",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=961,Name="Lebanon",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Lr",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=231,Name="Liberia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ly",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=218,Name="Libya",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="LI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=423,Name="Liechtenstein",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="LT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=370,Name="Lithuania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="LU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=352,Name="Luxembourg",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=853,Name="Macau",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=389,Name="Macedonia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=261,Name="Madagascar",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Mw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=265,Name="Malawi",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=60,Name="Malaysia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MV",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=960,Name="Maldives",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ml",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=223,Name="Mali",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=356,Name="Malta",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Mh",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=692,Name="Marshall Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Mr",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=222,Name="Mauritania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Mu",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=230,Name="Mauritius",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Yt",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=262,Name="Mayotte",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Mx",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1505,Name="Mexico",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Fm",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=691,Name="Micronesia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=373,Name="Moldova",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=377,Name="Monaco",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=976,Name="Mongolia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="ME",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=382,Name="Montenegro",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ms",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1664,Name="Montserrat",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ma",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=212,Name="Morocco",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Mz",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=258,Name="Mozambique",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Na",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=264,Name="Namibia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="NR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=674,Name="Nauru",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="NP",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=977,Name="Nepal",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="NL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=31,Name="Netherlands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="An",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=599,Name="Netherlands Antilles",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="NC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=687,Name="New Caledonia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="NZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=64,Name="New Zealand",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="NI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=505,Name="Nicaragua",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ne",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=227,Name="Niger",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ng",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=234,Name="Nigeria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="NU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=683,Name="Niue",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KP",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=850,Name="North Korea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="MP",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1670,Name="Northern Mariana Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="NO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=47,Name="Norway",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="OM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=968,Name="Oman",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=92,Name="Pakistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Pw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=680,Name="Palau",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=970,Name="Palestinian Territory, Occupied",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=507,Name="Panama",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Pg",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=675,Name="Papua New Guinea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=595,Name="Paraguay",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=51,Name="Peru",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=63,Name="Philippines",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=870,Name="Pitcairn Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=48,Name="Poland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=351,Name="Portugal",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1787,Name="Puerto Rico",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Pr",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1939,Name="Puerto Rico",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="QA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=974,Name="Qatar",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=242,Name="Republic Of The Congo",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="RO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=40,Name="Romania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="RU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=7,Name="Russia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Rw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=250,Name="Rwanda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="BL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=590,Name="Saint Barthelemy",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Sh",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=290,Name="Saint Helena",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1869,Name="Saint Kitts And Nevis",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="LC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1758,Name="Saint Lucia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="PM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=508,Name="Saint Pierre And Miquelon",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="VC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1784,Name="Saint Vincent And The Grenadines",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="WS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=685,Name="Samoa",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=378,Name="San Marino",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="ST",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=239,Name="Sao Tome And Principe",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=966,Name="Saudi Arabia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Sn",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=221,Name="Senegal",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="RS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=381,Name="Serbia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Sc",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=248,Name="Seychelles",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Sl",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=232,Name="Sierra Leone",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=65,Name="Singapore",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=421,Name="Slovakia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=386,Name="Slovenia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Sb",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=677,Name="Solomon Island",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="So",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=252,Name="Somalia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Za",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=27,Name="South Africa",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="KR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=82,Name="South Korea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ss",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=211,Name="South Sudan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="ES",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=34,Name="Spain",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="LK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=94,Name="Sri Lanka",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Sd",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=249,Name="Sudan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=597,Name="Suriname",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Sz",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=268,Name="Swaziland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=46,Name="Sweden",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="CH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=41,Name="Switzerland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="SY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=963,Name="Syria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TW",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=886,Name="Taiwan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TJ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=992,Name="Tajikistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Tz",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=255,Name="Tanzania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=66,Name="Thailand",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=670,Name="Timor-Leste",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Tg",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=228,Name="Togo",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=690,Name="Tokelau",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=676,Name="Tonga",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1868,Name="Trinidad And Tobago",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Tn",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=216,Name="Tunisia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=90,Name="Turkey",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=993,Name="Turkmenistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Tc",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1649,Name="Turks And Caicos Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="TV",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=688,Name="Tuvalu",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Ug",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=256,Name="Uganda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="UA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=380,Name="Ukraine",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="AE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=971,Name="United Arab Emirates",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="GB",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=44,Name="United Kingdom",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="US",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1,Name="United States",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="UY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=598,Name="Uruguay",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="UZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=998,Name="Uzbekistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="VU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=678,Name="Vanuatu",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="VE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=58,Name="Venezuela",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="VN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=84,Name="Vietnam",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="VG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1284,Name="Virgin Islands, British",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="VI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=1340,Name="Virgin Islands, U.S.",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="WF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=681,Name="Wallis And Futuna",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="YE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=967,Name="Yemen",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Zm",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=260,Name="Zambia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" },
                new Nationality { CountryCode="Zw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DialingCode=263,Name="Zimbabwe",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="127.0.0.1" }

            };

            nationality.ForEach(s => context.Nationalitys.Add(s));
            context.SaveChanges();
            #endregion

            #region Document
            var document = new List<Document>
            {
                new Document{CompanyId=1,CreationBy=1, CreationDate = DateTime.Now, CreationIP="127.0.0.1",Delete=false,Name="National Identity Card",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP="127.0.0.1"},
                new Document{CompanyId=1,CreationBy=1, CreationDate = DateTime.Now, CreationIP="127.0.0.1",Delete=false,Name="PassPort",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP="127.0.0.1"},
                new Document{CompanyId=1,CreationBy=1, CreationDate = DateTime.Now, CreationIP="127.0.0.1",Delete=false,Name="Visa",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP="127.0.0.1"},
                new Document{CompanyId=1,CreationBy=1, CreationDate = DateTime.Now, CreationIP="127.0.0.1",Delete=false,Name="Education",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP="127.0.0.1"},
                new Document{CompanyId=1,CreationBy=1, CreationDate = DateTime.Now, CreationIP="127.0.0.1",Delete=false,Name="Health Insurance",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP="127.0.0.1"}
            };

            document.ForEach(s => context.Documents.Add(s));
            context.SaveChanges();
            #endregion

            #region EmployeeDocument
            var employeedocument = new List<EmployeeDocument>
            {
                new EmployeeDocument{Comments="NIC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=1,DocumentNumber="42101-1612323-9",EmployeeId=1
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Passport #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=2,DocumentNumber="CH9893221",EmployeeId=1
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Visa #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=3,DocumentNumber="CH98254821",EmployeeId=1
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="SSC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="123456",EmployeeId=1
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="HSC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="123456",EmployeeId=1
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Bachlors Degree #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="123456",EmployeeId=1
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Masters Degree #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="123456",EmployeeId=1
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},

                new EmployeeDocument{Comments="NIC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=1,DocumentNumber="42101-1611234-9",EmployeeId=2
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Passport #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=2,DocumentNumber="CH9892221",EmployeeId=2
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Visa #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=3,DocumentNumber="CH92363221",EmployeeId=2
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="SSC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=2
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="HSC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=2
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Bachlors Degree #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=2
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Masters Degree #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=2
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},

                new EmployeeDocument{Comments="NIC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=1,DocumentNumber="42101-1611234-9",EmployeeId=3
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Passport #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=2,DocumentNumber="CH9892221",EmployeeId=3
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Visa #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=3,DocumentNumber="CH92363221",EmployeeId=3
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="SSC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=3
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="HSC #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=3
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Bachlors Degree #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=3
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""},
                new EmployeeDocument{Comments="Masters Degree #",UpdationIP="127.0.0.1",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="127.0.0.1",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=3
                ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,SoftCopyPath=""}
            };

            employeedocument.ForEach(s => context.EmployeeDocuments.Add(s));
            context.SaveChanges();
            #endregion

        }
    }
}