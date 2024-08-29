namespace JWT.Auth.BlazorUi.Models
{
    //Just the properties of the Account EntityType used for this sample
    // See https://learn.microsoft.com/power-apps/developer/data-platform/webapi/reference/account
    public class Account
    {
            public Guid accountid { get; set; }

            public string name { get; set; }

            public string telephone1 { get; set; }

            public string address1_city { get; set; }

        public Contact? primarycontactid { get; set; }
        
       public Contact Contact { get; set; }
        

    }
    }

