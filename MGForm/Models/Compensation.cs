using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGForm.Models
{
    public class Compensation
    {
        public string RV { get; set; }
        public string URN { get; set; }
        public string Offence { get; set; }
        public DateTime DateOffence { get; set; }
        public string Queries { get; set; }

        public string InsuranceDetails { get; set; }
        public string PolicyNo { get; set; }
        public List<Item> StolenItems { get; set; }
        public string StolenItemTotal { get; set; }

        public List<Item> ExpenseItems { get; set; }
        public string ExpenseTotal { get; set; }

        public string Injuries { get; set; }
        public string TreatmentReceived { get; set; }
        public string DateOfHospitalAttendance { get; set; }
        public string Doctor { get; set; }

        public string InsuranceCompany { get; set; }
        public string InsuranceAddress { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string LossOf { get; set; }
        public string LossOfAmount { get; set; }
        public string ExcessOnPolicy { get; set; }
        public string ExcessAmount { get; set; }
        public string ConfirmatoryLetterAttached { get; set; }

        public string ClaimantName { get; set; }
        public string ClaimantAddress { get; set; }
        public string ClaimantTel { get; set; }
        public string ClaimantMobile { get; set; }
        public string ClaimantEmail { get; set; }

        public string AttendAccidentAndEmergency { get; set; }
        public string ConfirmAttendedHospital { get; set; }
        public DateTime DateOfAttendance { get; set; }
        public string DoctorName { get; set; }

        public string ReferredToSpecialist { get; set; }
        public string ReferredHospital { get; set; }
        public DateTime ReferredDate { get; set; }
        public string ReferredDoctorName { get; set; }

        public string SeenGP { get; set; }
        public string GPName { get; set; }
        public string GPAddress { get; set; }
        public DateTime GPDate { get; set; }

    }

    

    public class Item
    {
        public string Name { get; set; }
        public string Amount { get; set; }
    }
}
