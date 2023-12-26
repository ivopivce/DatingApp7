using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using Microsoft.Net.Http.Headers;

namespace API.Entities;

public  class AppUser
{
    public int Id { get; set; }
     public string UserName { get; set; }

     public byte[] PasswordHash { get; set; }

     public byte[] PasswordSalt { get; set; }

     public string Address {get; set;}

     public string PhoneNumber {get; set;}

}