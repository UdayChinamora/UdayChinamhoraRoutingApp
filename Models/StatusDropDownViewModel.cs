namespace UdayChinhamoraWebsite.Models
{
    public class StatusDropDownViewModel
    {
        
        //Dictionary for statuses will hold an id and value string for each status
        public Dictionary<string, string> Statuses { get; set; }
        public string SelectedStatus { get; set; }
        public string DefaultStatus { get; set; }
    }
}
    

