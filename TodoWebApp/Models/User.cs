using System.ComponentModel.DataAnnotations;

namespace TodoWebApp.Models;
public class User {
    public int Id {get;set;}

    public string? username {get;set;}
    public string? firstname {get;set;}
    public string? email {get;set;}

    public string? mobile {get; set;}
}