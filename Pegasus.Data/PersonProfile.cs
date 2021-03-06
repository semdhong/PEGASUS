﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pegasus.Data
{
    public partial class PersonProfile
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "text")]
        public string Fullname { get; set; }
        public int? LguId { get; set; }
        public int? BrgyId { get; set; }
        [Column(TypeName = "text")]
        public string QrCode { get; set; }
        [Column(TypeName = "text")]
        public string PicPath { get; set; }
        public int? PrincipalPersonId { get; set; }
        public int? QDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? QDateStarted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? QDateEnded { get; set; }
        [Column(TypeName = "text")]
        public string PersonStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column(TypeName = "text")]
        public string Address { get; set; }
        [Column(TypeName = "text")]
        public string Contact { get; set; }
        public bool? BrgyVerified { get; set; }
        public bool? CHDOHVerified { get; set; }
        public int? Agent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SwabTestDate { get; set; }
        [Column(TypeName = "text")]
        public string BrgyRemarks { get; set; }
        [Column(TypeName = "text")]
        public string CHDOHRemarks { get; set; }

        [ForeignKey(nameof(Agent))]
        [InverseProperty(nameof(UserAgents.PersonProfile))]
        public virtual UserAgents AgentNavigation { get; set; }
        [ForeignKey(nameof(BrgyId))]
        [InverseProperty(nameof(Barangay.PersonProfile))]
        public virtual Barangay Brgy { get; set; }
    }
}