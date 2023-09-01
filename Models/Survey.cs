#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace SurveyParty.Models;

public class Survey
{
    [Required(ErrorMessage = "Please input a name")]
    public string Titles { get; set; }
    public string Locations { get; set; }
    public string Languages { get; set; }
    [Required(ErrorMessage = "Please add a comment")]
    public string Comments { get; set; }
}
