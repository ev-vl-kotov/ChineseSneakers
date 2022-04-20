using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ChineseSneakers.Models;

public class Order
{
    [BindNever]
    public int Id { get; set; }
    [Display(Name = "Введите имя")]
    public string Name { get; set; }
    
    [StringLength(20)]
    [Required(ErrorMessage = "Данная строка не может быть пустой")]
    public string Surname { get; set; }
    
    [StringLength(20)]
    [Required(ErrorMessage = "Данная строка не может быть пустой")]
    public string Adress { get; set; }
    
    [StringLength(20)]
    [Required(ErrorMessage = "Данная строка не может быть пустой")]
    public string Phone { get; set; }
    
    [StringLength(20)]
    [Required(ErrorMessage = "Данная строка не может быть пустой")]
    public string Email { get; set; }
    
    public DateTime OrderTime { get; set; }
    public List<Payment> Payments { get; set; }

}