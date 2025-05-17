using ClassLibrary.Model;
using System.Collections.Generic;

namespace WebApp.Models
{
    public class ManageEquipmentViewModel
    {
        public List<Equipment> EquipmentList { get; set; } = new();
        public CreateEquipmentViewModel CreateEquipment { get; set; } = new();
    }
}
