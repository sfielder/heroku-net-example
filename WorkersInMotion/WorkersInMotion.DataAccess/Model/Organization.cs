//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkersInMotion.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organization
    {
        public Organization()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
            this.ExceptionsOrganizations = new HashSet<ExceptionsOrganization>();
            this.OrganizationSubscriptions = new HashSet<OrganizationSubscription>();
            this.Regions = new HashSet<Region>();
            this.OrganizationUsersMaps = new HashSet<OrganizationUsersMap>();
            this.ShiftsOrganizations = new HashSet<ShiftsOrganization>();
            this.SkillsOrganizations = new HashSet<SkillsOrganization>();
            this.WorkDaysOrganizations = new HashSet<WorkDaysOrganization>();
        }
    
        public System.Guid OrganizationGUID { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationFullName { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public Nullable<double> TimeZone { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string EmailID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> AllowContractors { get; set; }
        public string ImageURL { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<System.Guid> LastModifiedBy { get; set; }
    
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual ICollection<ExceptionsOrganization> ExceptionsOrganizations { get; set; }
        public virtual ICollection<OrganizationSubscription> OrganizationSubscriptions { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<OrganizationUsersMap> OrganizationUsersMaps { get; set; }
        public virtual ICollection<ShiftsOrganization> ShiftsOrganizations { get; set; }
        public virtual ICollection<SkillsOrganization> SkillsOrganizations { get; set; }
        public virtual ICollection<WorkDaysOrganization> WorkDaysOrganizations { get; set; }
    }
}
