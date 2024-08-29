namespace JWT.Auth.BlazorUi.Models
{   
    //Just the properties of the Contact EntityType that are expanded from the Account entity
    // See https://learn.microsoft.com/power-apps/developer/data-platform/webapi/reference/contact
    public class Contact
    {
        public Guid contactid { get; set; }
        public string fullname { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string emailaddress1 { get; set; }
        
    }
   
}
