namespace JwtApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "kadir_admin", EmailAddress = "kadir.admin@email.com", Password ="MyPass_w@rd", GivenName="Kadir", Surname = "Karadag", Role = "Administrator" },
            new UserModel() { Username = "elyse_seller", EmailAddress = "elyse.seller@email.com", Password ="MyPass_w@rd", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" },
        };
    }
}
